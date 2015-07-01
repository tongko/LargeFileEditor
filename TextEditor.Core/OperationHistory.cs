namespace TextEditor.Core
{
	internal sealed class OperationHistory
	{
		private static readonly OperationHistory TheInstance = new OperationHistory();
		private readonly LinkedStack<Span> _redo = new LinkedStack<Span>();
		private readonly LinkedStack<Span> _undo = new LinkedStack<Span>();

		//	Explicit static constructor to tell C# compiler
		//	not to mark type as beforefieldinit
		static OperationHistory()
		{
		}

		private OperationHistory()
		{
		}

		public static OperationHistory Instance
		{
			get { return TheInstance; }
		}

		public void PushHistory(Span span)
		{
			_undo.Push(span);
		}

		public void PopHistory(Span span)
		{

		}
	}
}
