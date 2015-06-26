namespace TextEditor.Core
{
	public class LinkedStack<T>
	{
		private LinkedNode<T> _tail;

		public int Count { get; private set; }

		public bool IsEmpty { get { return Count == 0; } }

		public void Push(T value)
		{
			var node = new LinkedNode<T>(value);

			if (IsEmpty)
			{
				_tail = node;
			}
			else
			{
				Bind(_tail, node);
				_tail = node;
			}

			Count++;
		}

		public T Pop()
		{
			var node = _tail;
			if (node != null)
			{
				_tail = node.Previous;
				Count--;
			}

			return node == null ? default(T) : node.Value;
		}

		public T Peek()
		{
			return _tail == null ? default(T) : _tail.Value;
		}

		private static void Bind(LinkedNode<T> n1, LinkedNode<T> n2)
		{
			if (n1 != null) n1.Next = n2;
			if (n2 != null) n2.Previous = n1;
		}
	}
}
