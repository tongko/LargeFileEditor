
namespace TextEditor.Core
{
	public class DocumentView
	{
		private byte[] _buffer;

		internal DocumentView(Document document)
		{
			Document = document;
		}

		public Document Document { get; set; }

		public long Offset { get; set; }

		public long Length { get; set; }

		public DocumentView SetBuffer(byte[] buffer)
		{
			_buffer = buffer;
			return this;
		}
	}
}
