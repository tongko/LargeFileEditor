using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor.DocWell
{
	public partial class DocumentWell : UserControl
	{
		private int _tabHeight;
		private Rectangle _wellBounds;

		public DocumentWell()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText | ControlStyles.DoubleBuffer |
				ControlStyles.FixedHeight | ControlStyles.FixedWidth | ControlStyles.Opaque | ControlStyles.ResizeRedraw |
				ControlStyles.Selectable | ControlStyles.StandardClick | ControlStyles.UserPaint, true);
			InitializeComponent();
		}

		public event EventHandler<TabHeightChangingEventArgs> TabHeightChanging = delegate { };

		public event EventHandler TabHeightChanged = delegate { };

		public IList<DocumentTab> DocumentTabs { get; set; }

		public int SelectedTabIndex { get; set; }

		public int TabHeight
		{
			get { return _tabHeight; }
			set
			{
				var args = new TabHeightChangingEventArgs(value);
				if (args.CancelChange)
					return;

				_tabHeight = value;

				OnTabHeightChanged(EventArgs.Empty);
			}
		}

		protected virtual void OnTabHeightChanging(TabHeightChangingEventArgs args)
		{
			TabHeightChanging(this, args);
		}

		protected virtual void OnTabHeightChanged(EventArgs args)
		{
			TabHeightChanged(this, args);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var g = e.Graphics;

			//	Draw background
			g.Clear(BackColor);

			//	Draw Document Well

			//	Draw Document Border

			//	Draw Document
		}

		private void DrawWell(Graphics g)
		{

		}
	}
}
