using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace TextEditor.Core
{
	public class Document : IDisposable
	{
		private const int OffsetFactor = 32768;		//	32K
		private const int MemBlockSize = 65536;	//	64K
		private SpanTable _spanTable;
		private MemoryMappedFile _mapped;
		private MemoryMappedViewStream _stream;
		private FileStream _editBuffer;
		private int _viewIndex;
		private long _position;

		public Document()
		{
			TagId = Guid.NewGuid();
			_viewIndex = -1;
			_position = 0;
		}

		public Guid TagId { get; private set; }

		public string FileName { get; internal set; }

		public int Read(byte[] buffer, int index, int count)
		{
			Span span;
			var start = _spanTable.Find(_position, out span);
			if (start < 0)
				return 0;

			var c = count;
			while (count > 0 && span != null)
			{
				var len = span.Length > count ? count : span.Length;
				var temp = span.Buffer == 0
					? GetBufferFromMapped(span.Offset + start, (int)len)
					: GetBufferFromEdit(span.Offset + start, (int)len);

				count -= temp.Length;
				span = span.Next;
			}

			return c - count;
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
			var len = length > MemBlockSize ? MemBlockSize : length;
			var baseIdx = CalcIndexBase(offset);
			if (baseIdx != _stream.PointerOffset)
				_stream = _mapped.CreateViewStream(baseIdx, MemBlockSize);

			var buff = new byte[len];
			_stream.Position = offset - baseIdx;
			var count = _stream.Read(buff, 0, len);
			var temp = new byte[count];
			Array.Copy(buff, 0, temp, 0, count);

			return temp;
		}

		public DocumentView GetNextView()
		{
			Span span;

			var index = _spanTable.Find(++_viewIndex * OffsetFactor, out span);
			if (index < 0)
			{
				_viewIndex--;
				return null;
			}

			var idx = 0;
			var buffer = new byte[MemBlockSize];
			while (span != null)
			{
				var len = (int)Math.Min(MemBlockSize, span.Length);
				if (span.Buffer == 0)
				{
					var s = _mapped.CreateViewStream(span.Offset, len);
					var count = s.Read(buffer, idx, len);
					idx += count;
				}
				else
				{
					_editBuffer.Position = span.Offset;
					var count = _editBuffer.Read(buffer, idx, len);
					idx += count;
				}

				span = span.Next;
			}

			return new DocumentView(this) { Offset = _viewIndex * OffsetFactor, Length = idx }.SetBuffer(buffer);
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
			var path = Path.GetDirectoryName(FileName);
			if (string.IsNullOrWhiteSpace(path))
				path = Directory.GetCurrentDirectory();
			var editBuff = Path.Combine(path, "$" + Path.GetFileNameWithoutExtension(FileName) + ".working");
			_editBuffer = new FileStream(editBuff, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		}

		private void InitSpanTable()
		{
			_spanTable = new SpanTable();
			_spanTable.Insert(0, new FileInfo(FileName).Length);
		}

		public void Save()
		{

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
