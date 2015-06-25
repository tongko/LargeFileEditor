namespace TextEditor.Core
{
	public class SpanTable
	{
		private Span _head;
		private Span _tail;
		private long _currentOffset;

		public void Insert(long offset, long length)
		{
			Span s;
			if (_head == null)
			{
				s = new Span(0, 0, length);
				_head = _tail = s;
				_currentOffset = 0;
				return;
			}

			s = new Span(1, _currentOffset, length);
			_currentOffset += length;
			Span span;
			var index = Find(offset, out span);
			if (index == 0)		//	insert at begining of span
			{
				s.Previous = span.Previous;
				s.Next = span;
			}
			else if (index > 0)
			{
				var s1 = new Span(span.Buffer, span.Offset, index);
				var s2 = new Span(span.Buffer, index, span.Length - index);
				s1.Previous = span.Previous;
				s1.Next = s2.Previous = s;
				s.Next = s2;
				s2.Next = span.Next;
			}
			else if (index < 0)
			{
				_tail.Next = s;
				s.Previous = _tail;
			}
		}

		public void Delete(long offset, long length)
		{

		}

		public void Overwrite(long offset, long length)
		{
			Delete(offset, length);
			Insert(offset, length);
		}

		private long Find(long offset, out Span span)
		{
			long position = 0;
			var temp = _head;

			while (temp != null)
			{
				var tp = position;
				position += temp.Length;
				if (offset < position)
				{
					span = temp;
					return offset - tp - 1;
				}

				temp = temp.Next;
			}

			span = null;
			return -1;
		}
	}
}
