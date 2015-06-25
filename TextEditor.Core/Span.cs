namespace TextEditor.Core
{
	public class Span
	{
		public Span(int buffer, long offset, long length)
		{
			Buffer = buffer;
			Offset = offset;
			Length = length;

			Previous = Next = null;
		}

		public int Buffer { get; set; }

		public long Offset { get; set; }
		public long Length { get; set; }

		public Span Previous { get; set; }
		public Span Next { get; set; }
	}
}