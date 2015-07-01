namespace TextEditor.Core
{
	public class SpanTable
	{
		private readonly LinkedStack<Span> _redo = new LinkedStack<Span>();
		private readonly LinkedStack<Span> _undo = new LinkedStack<Span>();

		private Span _head;
		private Span _tail;
		private long _currentOffset;

#if DEBUG
		public Span Head { get { return _head; } }

		public Span Tail { get { return _tail; } }
#endif

		public void Insert(long offset, long length)
		{
			Span s;
			if (_head == null)
			{
				s = new Span(0, 0, length);
				_head = _tail = s;
				_currentOffset = 0;
				_undo.Push(null);
				return;
			}

			s = new Span(1, _currentOffset, length);
			_currentOffset += length;
			Span span;
			var index = Find(offset, out span);
			if (index == 0)		//	insert at begining of span
			{
				_undo.Push(span);
				s.Previous = span.Previous;
				if (s.Previous != null) s.Previous.Next = s;
				else
					_head = s;
				span.Previous = s;
				s.Next = span;

				if (s.Previous == null) _head = s;
			}
			else if (index > 0)
			{
				_undo.Push(span);
				var s1 = new Span(span.Buffer, span.Offset, index);
				var s2 = new Span(span.Buffer, index, span.Length - index);
				s1.Previous = span.Previous;
				s1.Next = s2.Previous = s;
				s.Previous = s1;
				s.Next = s2;
				s2.Next = span.Next;

				if (s1.Previous == null) _head = s1;
				if (s2.Next == null) _tail = s2;
			}
			else if (index < 0)
			{
				_undo.Push(new Span(s.Buffer, 0, 0) { Previous = _tail, Next = null });
				_tail.Next = s;
				s.Previous = _tail;
				_tail = s;
			}

			//	new action perform, clear redo stack.
			_redo.Clear();
		}

		public void Delete(long offset, long length)
		{
			if (_head == null)
				return;

			Span span;
			var index = Find(offset, out span);
			if (index < 0) return;		//	nothing to be delete beyond tail.

			var remain = length;
			while (remain > 0)
			{
				if (span == null)	//	already at the end of table.
					break;

				var toDeleteFromSpan = span.Length - index;
				if (remain < toDeleteFromSpan)
					toDeleteFromSpan = remain;
				var s1 = new Span(span.Buffer, span.Offset, index);
				var s2 = new Span(span.Buffer, index + toDeleteFromSpan, span.Length - toDeleteFromSpan - index);

				if (toDeleteFromSpan == span.Length)
					Bind(span.Previous, span.Next);
				else
				{
					var p = span.Previous;
					var n = span.Next;
					if (s1.Length <= 0 || s2.Length <= 0) //	delete from begining of span.
					{
						var sx = s1.Length == 0 ? s2 : s1;
						if (p != null)
							Bind(p, sx);
						else
						{
							sx.Previous = null;
							_head = sx;
						}
						if (n != null)
							Bind(sx, n);
						else
						{
							sx.Next = null;
							_tail = sx;
						}
					}
					else
					{
						if (p != null)
							Bind(p, s1);
						else
							s1.Previous = null;
						Bind(s1, s2);
						if (n != null)
							Bind(s2, n);
						else
							s2.Next = null;
					}
				}

				remain -= toDeleteFromSpan;
				_undo.Push(span);
				span = span.Next;
				index = 0;
			}

			//	new operation performed, clear redo stack.
			_redo.Clear();
		}

		public void Overwrite(long offset, long length)
		{
			Delete(offset, length);
			Insert(offset, length);
		}

		public void Undo()
		{
			var span = _undo.Pop();
			if (span == null)
			{
				_redo.Push(_head);
				_head = null;
			}
			else if (span.Length == 0)
			{
				Span s1;
				if (span.Previous != null)
				{
					s1 = _tail.Next;
					_redo.Push(s1);
					_tail = span.Previous;
					_tail.Next = null;
				}
				else if (span.Next != null)
				{
					s1 = _head.Next;
					_redo.Push(s1);
					_head = span.Next;
					_head.Previous = null;
				}
			}
			else
			{
				_redo.Push(span.Previous.Next);
				Bind(span.Previous, span);
				Bind(span, span.Next);
			}
		}

		public void Redo()
		{
			var span = _redo.Pop();
			if (span != null)
			{
				_undo.Push(span.Previous.Next);
				Bind(span.Previous, span);
				while (span.Next.Previous == span)
					span = span.Next;
				Bind(span, span.Next);
			}
		}

		private static void Bind(Span s1, Span s2)
		{
			if (s1 != null) s1.Next = s2;
			if (s2 != null) s2.Previous = s1;
		}

		public long Find(long offset, out Span span)
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
					return offset - tp;
				}

				temp = temp.Next;
			}

			span = null;
			return -1;
		}
	}
}
