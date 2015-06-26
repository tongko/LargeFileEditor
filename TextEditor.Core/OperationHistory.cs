namespace TextEditor.Core
{
	internal sealed class OperationHistory
	{
		private static readonly OperationHistory TheInstance = new OperationHistory();

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
	}
}
