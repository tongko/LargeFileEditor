using System;

namespace TextEditor.DocWell
{
	public class TabHeightChangingEventArgs : EventArgs
	{
		public TabHeightChangingEventArgs(int newHeight)
		{
			NewHeight = newHeight;
		}

		public bool CancelChange { get; set; }

		public int NewHeight { get; private set; }
	}
}
