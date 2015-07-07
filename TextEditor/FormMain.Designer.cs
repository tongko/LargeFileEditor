namespace TextEditor
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFilePreview = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsCustomize = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsOption = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWindowWindows = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpContent = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusDocType = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCursorPos = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusEncoding = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.statusEdit = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusKeyboard = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuTools,
            this.mnuWindow,
            this.mnuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.toolStripSeparator,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.mnuFilePrint,
            this.mnuFilePreview,
            this.toolStripSeparator2,
            this.mnuFileExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "&File";
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
			this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mnuFileNew.Size = new System.Drawing.Size(146, 22);
			this.mnuFileNew.Text = "&New";
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
			this.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuFileOpen.Size = new System.Drawing.Size(146, 22);
			this.mnuFileOpen.Text = "&Open";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// mnuFileSave
			// 
			this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
			this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileSave.Name = "mnuFileSave";
			this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuFileSave.Size = new System.Drawing.Size(146, 22);
			this.mnuFileSave.Text = "&Save";
			// 
			// mnuFileSaveAs
			// 
			this.mnuFileSaveAs.Name = "mnuFileSaveAs";
			this.mnuFileSaveAs.Size = new System.Drawing.Size(146, 22);
			this.mnuFileSaveAs.Text = "Save &As";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// mnuFilePrint
			// 
			this.mnuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilePrint.Image")));
			this.mnuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFilePrint.Name = "mnuFilePrint";
			this.mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.mnuFilePrint.Size = new System.Drawing.Size(146, 22);
			this.mnuFilePrint.Text = "&Print";
			// 
			// mnuFilePreview
			// 
			this.mnuFilePreview.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilePreview.Image")));
			this.mnuFilePreview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFilePreview.Name = "mnuFilePreview";
			this.mnuFilePreview.Size = new System.Drawing.Size(146, 22);
			this.mnuFilePreview.Text = "Print Pre&view";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.mnuFileExit.Size = new System.Drawing.Size(146, 22);
			this.mnuFileExit.Text = "E&xit";
			// 
			// mnuEdit
			// 
			this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo,
            this.mnuEditRedo,
            this.toolStripSeparator3,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.toolStripSeparator4,
            this.mnuEditSelectAll});
			this.mnuEdit.Name = "mnuEdit";
			this.mnuEdit.Size = new System.Drawing.Size(39, 20);
			this.mnuEdit.Text = "&Edit";
			// 
			// mnuEditUndo
			// 
			this.mnuEditUndo.Name = "mnuEditUndo";
			this.mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.mnuEditUndo.Size = new System.Drawing.Size(164, 22);
			this.mnuEditUndo.Text = "&Undo";
			// 
			// mnuEditRedo
			// 
			this.mnuEditRedo.Name = "mnuEditRedo";
			this.mnuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.mnuEditRedo.Size = new System.Drawing.Size(164, 22);
			this.mnuEditRedo.Text = "&Redo";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
			// 
			// mnuEditCut
			// 
			this.mnuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCut.Image")));
			this.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditCut.Name = "mnuEditCut";
			this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.mnuEditCut.Size = new System.Drawing.Size(164, 22);
			this.mnuEditCut.Text = "Cu&t";
			// 
			// mnuEditCopy
			// 
			this.mnuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCopy.Image")));
			this.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditCopy.Name = "mnuEditCopy";
			this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.mnuEditCopy.Size = new System.Drawing.Size(164, 22);
			this.mnuEditCopy.Text = "&Copy";
			// 
			// mnuEditPaste
			// 
			this.mnuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditPaste.Image")));
			this.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditPaste.Name = "mnuEditPaste";
			this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.mnuEditPaste.Size = new System.Drawing.Size(164, 22);
			this.mnuEditPaste.Text = "&Paste";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
			// 
			// mnuEditSelectAll
			// 
			this.mnuEditSelectAll.Name = "mnuEditSelectAll";
			this.mnuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.mnuEditSelectAll.Size = new System.Drawing.Size(164, 22);
			this.mnuEditSelectAll.Text = "Select &All";
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsCustomize,
            this.mnuToolsOption});
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(48, 20);
			this.mnuTools.Text = "&Tools";
			// 
			// mnuToolsCustomize
			// 
			this.mnuToolsCustomize.Name = "mnuToolsCustomize";
			this.mnuToolsCustomize.Size = new System.Drawing.Size(130, 22);
			this.mnuToolsCustomize.Text = "&Customize";
			// 
			// mnuToolsOption
			// 
			this.mnuToolsOption.Name = "mnuToolsOption";
			this.mnuToolsOption.Size = new System.Drawing.Size(130, 22);
			this.mnuToolsOption.Text = "&Options";
			// 
			// mnuWindow
			// 
			this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowWindows});
			this.mnuWindow.Name = "mnuWindow";
			this.mnuWindow.Size = new System.Drawing.Size(63, 20);
			this.mnuWindow.Text = "&Window";
			// 
			// mnuWindowWindows
			// 
			this.mnuWindowWindows.Name = "mnuWindowWindows";
			this.mnuWindowWindows.Size = new System.Drawing.Size(132, 22);
			this.mnuWindowWindows.Text = "Windows...";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpContent,
            this.mnuHelpIndex,
            this.mnuHelpSearch,
            this.toolStripSeparator5,
            this.mnuHelpAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "&Help";
			// 
			// mnuHelpContent
			// 
			this.mnuHelpContent.Name = "mnuHelpContent";
			this.mnuHelpContent.Size = new System.Drawing.Size(122, 22);
			this.mnuHelpContent.Text = "&Contents";
			// 
			// mnuHelpIndex
			// 
			this.mnuHelpIndex.Name = "mnuHelpIndex";
			this.mnuHelpIndex.Size = new System.Drawing.Size(122, 22);
			this.mnuHelpIndex.Text = "&Index";
			// 
			// mnuHelpSearch
			// 
			this.mnuHelpSearch.Name = "mnuHelpSearch";
			this.mnuHelpSearch.Size = new System.Drawing.Size(122, 22);
			this.mnuHelpSearch.Text = "&Search";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
			// 
			// mnuHelpAbout
			// 
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(122, 22);
			this.mnuHelpAbout.Text = "&About...";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "&New";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name = "cutToolStripButton";
			this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text = "C&ut";
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDocType,
            this.statusCursorPos,
            this.statusEncoding,
            this.statusProgress,
            this.statusEdit,
            this.statusKeyboard});
			this.statusStrip1.Location = new System.Drawing.Point(0, 625);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1016, 24);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusDocType
			// 
			this.statusDocType.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusDocType.Name = "statusDocType";
			this.statusDocType.Size = new System.Drawing.Size(578, 19);
			this.statusDocType.Spring = true;
			// 
			// statusCursorPos
			// 
			this.statusCursorPos.AutoSize = false;
			this.statusCursorPos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusCursorPos.Name = "statusCursorPos";
			this.statusCursorPos.Size = new System.Drawing.Size(200, 19);
			// 
			// statusEncoding
			// 
			this.statusEncoding.AutoSize = false;
			this.statusEncoding.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusEncoding.Name = "statusEncoding";
			this.statusEncoding.Size = new System.Drawing.Size(150, 19);
			// 
			// statusProgress
			// 
			this.statusProgress.AutoSize = false;
			this.statusProgress.Name = "statusProgress";
			this.statusProgress.Size = new System.Drawing.Size(100, 18);
			this.statusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.statusProgress.Visible = false;
			// 
			// statusEdit
			// 
			this.statusEdit.AutoSize = false;
			this.statusEdit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusEdit.Name = "statusEdit";
			this.statusEdit.Size = new System.Drawing.Size(35, 19);
			this.statusEdit.Text = "INS";
			// 
			// statusKeyboard
			// 
			this.statusKeyboard.AutoSize = false;
			this.statusKeyboard.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.statusKeyboard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusKeyboard.Name = "statusKeyboard";
			this.statusKeyboard.Size = new System.Drawing.Size(38, 19);
			this.statusKeyboard.Text = "CAPS";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 649);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Big File Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
		private System.Windows.Forms.ToolStripMenuItem mnuFilePreview;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuEditUndo;
		private System.Windows.Forms.ToolStripMenuItem mnuEditRedo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
		private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
		private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAll;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsCustomize;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsOption;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpContent;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpIndex;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpSearch;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripStatusLabel statusDocType;
		private System.Windows.Forms.ToolStripStatusLabel statusCursorPos;
		private System.Windows.Forms.ToolStripStatusLabel statusEncoding;
		private System.Windows.Forms.ToolStripProgressBar statusProgress;
		private System.Windows.Forms.ToolStripStatusLabel statusEdit;
		private System.Windows.Forms.ToolStripStatusLabel statusKeyboard;
		private System.Windows.Forms.ToolStripMenuItem mnuWindow;
		private System.Windows.Forms.ToolStripMenuItem mnuWindowWindows;
	}
}

