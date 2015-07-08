
using System.Windows.Forms;

namespace TextEditor.DocWell
{
	public class DocumentTab
	{
		private readonly DocumentWell _container;
		private string _fileName;
		private float _width;

		public DocumentTab(DocumentWell container)
		{
			_container = container;
		}

		public string FileName
		{
			get { return _fileName; }
			set
			{
				_fileName = value;
				CalculateWidth();
			}
		}

		public float Width { get { return _width; } }

		private void CalculateWidth()
		{
			var font = _container.Font;
			var sizeF = TextRenderer.MeasureText(FileName, font);

			_width = sizeF.Width;
		}
	}
}
