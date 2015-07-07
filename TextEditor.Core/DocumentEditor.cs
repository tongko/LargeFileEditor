using System;
using System.Text;

namespace TextEditor.Core
{
	public abstract class DocumentEditor : IDisposable
	{
		private long _positoin;

		internal DocumentEditor(Document document)
		{
			Document = document;
		}

		public Encoding CurrentEncoding { get; protected set; }

		public Document Document { get; private set; }

		public bool EndOfDocument { get; protected set; }

		public long LineNumber { get; protected set; }

		public long Position
		{
			get { return _positoin; }
			set { Document.Position = value; }
		}

		public long PositionInLine { get; protected set; }

		public abstract void Close();

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				var doc = Document as IDisposable;
				if (doc != null)
					doc.Dispose();
			}
		}

		public abstract int Peek();

		public abstract int Read();

		public abstract int Read(char[] buffer, int index, int count);

		public abstract string ReadLine();

		public abstract void Write(string value);

		public abstract void WriteLine(string value);


		#region IDisposable

		void IDisposable.Dispose()
		{
			Dispose(true);
		}

		#endregion
	}
}