using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace TextEditor.Core
{
	public class Document : IDisposable
	{
		//private const int OffsetFactor = 32768;		//	32K
		private const int MemBlockSize = 65536;	//	64K
		private SpanTable _spanTable;
		private MemoryMappedFile _mapped;
		private MemoryMappedViewStream _stream;
		private FileStream _editBuffer;
		//private int _viewIndex;
		private long _position;

		public Document()
		{
			TagId = Guid.NewGuid();
			//_viewIndex = -1;
			_position = 0;
			BufferSize = 4096;
		}

		public int BufferSize { get; set; }

		public Guid TagId { get; private set; }

		public string FileName { get; internal set; }

		public int Read(byte[] buffer, int index, int count)
		{
			Span span;
			if (count > MemBlockSize)
				count = MemBlockSize;

			var start = _spanTable.Find(_position, out span);
			if (start < 0)
				return 0;

			var c = count;
			while (count > 0 && span != null)
			{
				var len = span.Length - start;
				len = len > count ? count : len;
				var temp = span.Buffer == 0
					? GetBufferFromMapped(span.Offset + start, (int)len)
					: GetBufferFromEdit(span.Offset + start, (int)len);

				count -= temp.Length;
				span = span.Next;
			}

			var readCount = c - count;
			_position += readCount;
			return readCount;
		}

		private byte[] GetBufferFromEdit(long offset, int length)
		{
			_editBuffer.Position = offset;
			var buff = new byte[length];
			var count = _editBuffer.Read(buff, 0, length);
			if (length == count)
				return buff;

			var temp = new byte[count];
			Array.Copy(buff, 0, temp, 0, count);

			return temp;
		}

		private byte[] GetBufferFromMapped(long offset, int length)
		{
			var baseIdx = CalcIndexBase(offset);
			if (baseIdx != _stream.PointerOffset)
				_stream = _mapped.CreateViewStream(baseIdx, MemBlockSize);

			var start = offset - baseIdx;
			var len = (int)(_stream.Length - start);
			len = len < length ? len : length;

			var buff = new byte[len];
			_stream.Position = start;
			var count = _stream.Read(buff, 0, len);
			if (len == count)
				return buff;

			var temp = new byte[count];
			Array.Copy(buff, 0, temp, 0, count);

			return temp;
		}

		private static long CalcIndexBase(long index)
		{
			if (index < MemBlockSize / 2)
				return 0;
			return ((index + MemBlockSize / 4) & (~(MemBlockSize / 2 - 1))) - MemBlockSize / 2;
		}

		public void Open()
		{
			if (string.IsNullOrWhiteSpace(FileName))
				throw new InvalidOperationException("No file specified.");

			CreateMappedFile();
			CreateEditBuffer();
			InitSpanTable();
		}

		private void CreateMappedFile()
		{
			if (!File.Exists(FileName))
				throw new InvalidOperationException("Invalid file name.",
					new FileNotFoundException("System cannot find the file specified.", FileName));

			_mapped = MemoryMappedFile.CreateFromFile(FileName, FileMode.Open, TagId.ToString());
		}

		private void CreateEditBuffer()
		{
			var editBuff = GetNameWithPrefix(FileName, "working");
			_editBuffer = new FileStream(editBuff, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		}

		private static string GetNameWithPrefix(string fileName, string extension)
		{
			var path = Path.GetDirectoryName(fileName);
			if (string.IsNullOrWhiteSpace(path))
				path = Directory.GetCurrentDirectory();
			return Path.Combine(path, "." + Path.GetFileNameWithoutExtension(fileName) + "." + extension);
		}

		private void InitSpanTable()
		{
			_spanTable = new SpanTable();
			_spanTable.Insert(0, new FileInfo(FileName).Length);
		}

		public void Save()
		{
			var saveBuff = GetNameWithPrefix(FileName, "saving");
			using (var fs = new FileStream(saveBuff, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				var span = _spanTable.Head;
				while (span != null)
				{
					WriteMappedToStream(fs, span.Offset, span.Length, span.Buffer == 0);
					span = span.Next;
				}
			}

			File.Move(saveBuff, FileName);
			_mapped.Dispose();
			_editBuffer.Dispose();

			Open();
		}

		public void WriteMappedToStream(Stream stream, long offset, long length, bool writeToMapped)
		{
			while (length > 0)
			{
				var source = writeToMapped ? (Stream)_stream : _editBuffer;
				if (writeToMapped)
				{
					var idxBase = CalcIndexBase(offset);
					if (idxBase != _stream.PointerOffset)
					{
						_stream = _mapped.CreateViewStream(idxBase, MemBlockSize);
						source = _stream;
					}
					_stream.Position = offset - _stream.PointerOffset;
				}
				else
					_editBuffer.Position = offset;

				var len = length > BufferSize ? BufferSize : length;
				var buffer = new byte[len];
				var count = source.Read(buffer, 0, (int)len);
				if (count <= 0)
					break;

				stream.Write(buffer, 0, count);
				length -= count;
				offset += count;
			}
		}

		public void Close()
		{
			if (_mapped != null)
				_mapped.Dispose();
			if (_editBuffer != null)
				_editBuffer.Dispose();
		}

		public void Dispose()
		{
			Dispose(true);
		}

		protected void Dispose(bool disposing)
		{
			if (disposing)
			{
				Close();
			}
		}
	}
}
