using System.Text;

namespace TextEditor.Core
{
	public class RuntimeSettings
	{
		private static readonly RuntimeSettings TheInstance = new RuntimeSettings();

		//	Explicit static constructor to tell C# compiler
		//	not to mark type as beforefieldinit
		static RuntimeSettings()
		{
		}

		private RuntimeSettings()
		{
		}

		public static RuntimeSettings Instance { get { return TheInstance; } }

		public Encoding DefaultEncoding { get; set; }


	}
}
