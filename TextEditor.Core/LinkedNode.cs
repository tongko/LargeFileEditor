namespace TextEditor.Core
{
	public class LinkedNode<T>
	{
		public LinkedNode(T value)
		{
			Value = value;
		}

		public T Value { get; private set; }

		public LinkedNode<T> Previous { get; set; }

		public LinkedNode<T> Next { get; set; }
	}
}
