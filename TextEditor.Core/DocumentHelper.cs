using System;
using System.IO;

namespace TextEditor.Core
{
	public static class DocumentHelper
	{
		public static Document LoadFrom(string fileName)
		{
			if (string.IsNullOrWhiteSpace(fileName))
				throw new ArgumentNullException("fileName");
			if (!File.Exists(fileName))
				throw new ArgumentException("Invalid file name specified.", "fileName",
					new FileNotFoundException("System cannot find the file.", fileName));

			var doc = new Document { FileName = fileName };
		}

	}
}
