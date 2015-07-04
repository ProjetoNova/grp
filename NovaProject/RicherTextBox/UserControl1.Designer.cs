namespace RicherTextBox
{
    partial class RicherTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RicherTextBox));
            this.rtbDocument = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtZoomFactor = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFindReplace = new System.Windows.Forms.ToolStrip();
            this.tstxtSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnFind = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReplace = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChooseFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWordWrap = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIndent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOutdent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBullets = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInsertPicture = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.toolStripFindReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDocument
            // 
            this.rtbDocument.AcceptsTab = true;
            this.rtbDocument.ContextMenuStrip = this.contextMenu;
            this.rtbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocument.EnableAutoDragDrop = true;
            this.rtbDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDocument.Location = new System.Drawing.Point(0, 51);
            this.rtbDocument.Name = "rtbDocument";
            this.rtbDocument.Size = new System.Drawing.Size(667, 262);
            this.rtbDocument.TabIndex = 0;
            this.rtbDocument.Text = "";
            this.rtbDocument.SelectionChanged += new System.EventHandler(this.rtbDocument_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnOpen,
            this.toolStripSeparator6,
            this.tscmbFont,
            this.tscmbFontSize,
            this.tsbtnChooseFont,
            this.toolStripSeparator1,
            this.tsbtnBold,
            this.tsbtnItalic,
            this.tsbtnUnderline,
            this.toolStripSeparator2,
            this.tsbtnAlignLeft,
            this.tsbtnAlignCenter,
            this.tsbtnAlignRight,
            this.toolStripSeparator3,
            this.tsbtnFontColor,
            this.tsbtnWordWrap,
            this.toolStripSeparator4,
            this.tsbtnIndent,
            this.tsbtnOutdent,
            this.tsbtnBullets,
            this.toolStripSeparator5,
            this.tsbtnInsertPicture,
            this.toolStripSeparator7,
            this.tsbtnZoomIn,
            this.tsbtnZoomOut,
            this.tstxtZoomFactor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 26);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 26);
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 26);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_Click);
            // 
            // tscmbFontSize
            // 
            this.tscmbFontSize.AutoSize = false;
            this.tscmbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tscmbFontSize.Name = "tscmbFontSize";
            this.tscmbFontSize.Size = new System.Drawing.Size(40, 21);
            this.tscmbFontSize.SelectedIndexChanged += new System.EventHandler(this.tscmbFontSize_Click);
            this.tscmbFontSize.TextChanged += new System.EventHandler(this.tscmbFontSize_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.CheckOnClick = true;
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(24, 23);
            this.tsbtnBold.Text = "B";
            this.tsbtnBold.ToolTipText = "Toggle Bold";
            this.tsbtnBold.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // tsbtnItalic
            // 
            this.tsbtnItalic.CheckOnClick = true;
            this.tsbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnItalic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.tsbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalic.Name = "tsbtnItalic";
            this.tsbtnItalic.Size = new System.Drawing.Size(23, 23);
            this.tsbtnItalic.Text = "I";
            this.tsbtnItalic.ToolTipText = "Toggle Italic";
            this.tsbtnItalic.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // tsbtnUnderline
            // 
            this.tsbtnUnderline.CheckOnClick = true;
            this.tsbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUnderline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline);
            this.tsbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnderline.Name = "tsbtnUnderline";
            this.tsbtnUnderline.Size = new System.Drawing.Size(24, 23);
            this.tsbtnUnderline.Text = "U";
            this.tsbtnUnderline.ToolTipText = "Toggle Underline";
            this.tsbtnUnderline.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            // 
            // tstxtZoomFactor
            // 
            this.tstxtZoomFactor.Name = "tstxtZoomFactor";
            this.tstxtZoomFactor.Size = new System.Drawing.Size(30, 26);
            this.tstxtZoomFactor.Leave += new System.EventHandler(this.tstxtZoomFactor_Leave);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.alignmentToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.indentationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.insertPictureToolStripMenuItem,
            this.toolStripMenuItem4,
            this.zoomInToolStripMenuItem,
            this.zoomOuToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(151, 314);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.styleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.CheckOnClick = true;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.CheckOnClick = true;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.CheckOnClick = true;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripFindReplace
            // 
            this.toolStripFindReplace.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFindReplace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtSearchText,
            this.tsbtnFind,
            this.tsbtnReplace});
            this.toolStripFindReplace.Location = new System.Drawing.Point(0, 26);
            this.toolStripFindReplace.Name = "toolStripFindReplace";
            this.toolStripFindReplace.Size = new System.Drawing.Size(667, 25);
            this.toolStripFindReplace.TabIndex = 1;
            this.toolStripFindReplace.Text = "toolStrip2";
            // 
            // tstxtSearchText
            // 
            this.tstxtSearchText.Name = "tstxtSearchText";
            this.tstxtSearchText.Size = new System.Drawing.Size(100, 25);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteToolStripMenuItem.Text = "Clear";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.alignmentToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.AlignTableCellMiddleCenterHS;
            this.alignmentToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.CheckOnClick = true;
            this.leftToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.AlignTableCellMiddleLeftJustHS;
            this.leftToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.CheckOnClick = true;
            this.centerToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.AlignTableCellMiddleCenterHS;
            this.centerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.CheckOnClick = true;
            this.rightToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.AlignTableCellMiddleRightHS;
            this.rightToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // indentationToolStripMenuItem
            // 
            this.indentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.bulletsToolStripMenuItem});
            this.indentationToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.List_BulletsHS;
            this.indentationToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indentationToolStripMenuItem.Name = "indentationToolStripMenuItem";
            this.indentationToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.indentationToolStripMenuItem.Text = "Indentation";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.IndentHS;
            this.increaseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.OutdentHS;
            this.decreaseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // bulletsToolStripMenuItem
            // 
            this.bulletsToolStripMenuItem.CheckOnClick = true;
            this.bulletsToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.List_BulletsHS;
            this.bulletsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.bulletsToolStripMenuItem.Name = "bulletsToolStripMenuItem";
            this.bulletsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bulletsToolStripMenuItem.Text = "Bullets";
            this.bulletsToolStripMenuItem.Click += new System.EventHandler(this.bulletsToolStripMenuItem_Click);
            // 
            // insertPictureToolStripMenuItem
            // 
            this.insertPictureToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.InsertPictureHS;
            this.insertPictureToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.insertPictureToolStripMenuItem.Name = "insertPictureToolStripMenuItem";
            this.insertPictureToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.insertPictureToolStripMenuItem.Text = "Insert Picture";
            this.insertPictureToolStripMenuItem.Click += new System.EventHandler(this.insertPictureToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.ZoomIn;
            this.zoomInToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOuToolStripMenuItem
            // 
            this.zoomOuToolStripMenuItem.Image = global::RicherTextBox.Properties.Resources.ZoomOut;
            this.zoomOuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.zoomOuToolStripMenuItem.Name = "zoomOuToolStripMenuItem";
            this.zoomOuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.zoomOuToolStripMenuItem.Text = "Zoom Out";
            this.zoomOuToolStripMenuItem.Click += new System.EventHandler(this.zoomOuToolStripMenuItem_Click);
            // 
            // tsbtnFind
            // 
            this.tsbtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFind.Image = global::RicherTextBox.Properties.Resources.FindHS;
            this.tsbtnFind.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnFind.Name = "tsbtnFind";
            this.tsbtnFind.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFind.Text = "toolStripButton1";
            this.tsbtnFind.ToolTipText = "Find";
            this.tsbtnFind.Click += new System.EventHandler(this.tsbtnFind_Click);
            // 
            // tsbtnReplace
            // 
            this.tsbtnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReplace.Image = global::RicherTextBox.Properties.Resources.FindNextHS;
            this.tsbtnReplace.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnReplace.Name = "tsbtnReplace";
            this.tsbtnReplace.Size = new System.Drawing.Size(23, 22);
            this.tsbtnReplace.Text = "toolStripButton2";
            this.tsbtnReplace.ToolTipText = "Replace";
            this.tsbtnReplace.Click += new System.EventHandler(this.tsbtnReplace_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 23);
            this.tsbtnSave.Text = "toolStripButton1";
            this.tsbtnSave.ToolTipText = "Save Document";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpen.Image")));
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 23);
            this.tsbtnOpen.Text = "toolStripButton2";
            this.tsbtnOpen.ToolTipText = "Load Document";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // tsbtnChooseFont
            // 
            this.tsbtnChooseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnChooseFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChooseFont.Image")));
            this.tsbtnChooseFont.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnChooseFont.Name = "tsbtnChooseFont";
            this.tsbtnChooseFont.Size = new System.Drawing.Size(23, 23);
            this.tsbtnChooseFont.Text = "toolStripButton1";
            this.tsbtnChooseFont.ToolTipText = "Select Font";
            this.tsbtnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // tsbtnAlignLeft
            // 
            this.tsbtnAlignLeft.CheckOnClick = true;
            this.tsbtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignLeft.Image")));
            this.tsbtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignLeft.Name = "tsbtnAlignLeft";
            this.tsbtnAlignLeft.Size = new System.Drawing.Size(23, 23);
            this.tsbtnAlignLeft.Text = "toolStripButton1";
            this.tsbtnAlignLeft.ToolTipText = "Align Left";
            this.tsbtnAlignLeft.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnAlignCenter
            // 
            this.tsbtnAlignCenter.CheckOnClick = true;
            this.tsbtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignCenter.Image")));
            this.tsbtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignCenter.Name = "tsbtnAlignCenter";
            this.tsbtnAlignCenter.Size = new System.Drawing.Size(23, 23);
            this.tsbtnAlignCenter.Text = "toolStripButton2";
            this.tsbtnAlignCenter.ToolTipText = "Align Center";
            this.tsbtnAlignCenter.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnAlignRight
            // 
            this.tsbtnAlignRight.CheckOnClick = true;
            this.tsbtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignRight.Image")));
            this.tsbtnAlignRight.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignRight.Name = "tsbtnAlignRight";
            this.tsbtnAlignRight.Size = new System.Drawing.Size(23, 23);
            this.tsbtnAlignRight.Text = "toolStripButton3";
            this.tsbtnAlignRight.ToolTipText = "Align Right";
            this.tsbtnAlignRight.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnFontColor
            // 
            this.tsbtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFontColor.Image")));
            this.tsbtnFontColor.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnFontColor.Name = "tsbtnFontColor";
            this.tsbtnFontColor.Size = new System.Drawing.Size(23, 23);
            this.tsbtnFontColor.Text = "toolStripButton4";
            this.tsbtnFontColor.ToolTipText = "Pick Font Color";
            this.tsbtnFontColor.Click += new System.EventHandler(this.tsbtnFontColor_Click);
            // 
            // tsbtnWordWrap
            // 
            this.tsbtnWordWrap.CheckOnClick = true;
            this.tsbtnWordWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWordWrap.Image")));
            this.tsbtnWordWrap.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnWordWrap.Name = "tsbtnWordWrap";
            this.tsbtnWordWrap.Size = new System.Drawing.Size(23, 23);
            this.tsbtnWordWrap.Text = "toolStripButton1";
            this.tsbtnWordWrap.ToolTipText = "Word Wrap";
            this.tsbtnWordWrap.Click += new System.EventHandler(this.tsbtnWordWrap_Click);
            // 
            // tsbtnIndent
            // 
            this.tsbtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIndent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIndent.Image")));
            this.tsbtnIndent.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnIndent.Name = "tsbtnIndent";
            this.tsbtnIndent.Size = new System.Drawing.Size(23, 23);
            this.tsbtnIndent.Text = "toolStripButton1";
            this.tsbtnIndent.ToolTipText = "Indent";
            this.tsbtnIndent.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnOutdent
            // 
            this.tsbtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOutdent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOutdent.Image")));
            this.tsbtnOutdent.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnOutdent.Name = "tsbtnOutdent";
            this.tsbtnOutdent.Size = new System.Drawing.Size(23, 23);
            this.tsbtnOutdent.Text = "toolStripButton3";
            this.tsbtnOutdent.ToolTipText = "Outdent";
            this.tsbtnOutdent.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnBullets
            // 
            this.tsbtnBullets.CheckOnClick = true;
            this.tsbtnBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBullets.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBullets.Image")));
            this.tsbtnBullets.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnBullets.Name = "tsbtnBullets";
            this.tsbtnBullets.Size = new System.Drawing.Size(23, 23);
            this.tsbtnBullets.Text = "toolStripButton2";
            this.tsbtnBullets.ToolTipText = "Toggle Bullets";
            this.tsbtnBullets.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnInsertPicture
            // 
            this.tsbtnInsertPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInsertPicture.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertPicture.Image")));
            this.tsbtnInsertPicture.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnInsertPicture.Name = "tsbtnInsertPicture";
            this.tsbtnInsertPicture.Size = new System.Drawing.Size(23, 23);
            this.tsbtnInsertPicture.Text = "toolStripButton1";
            this.tsbtnInsertPicture.ToolTipText = "Insert Picture";
            this.tsbtnInsertPicture.Click += new System.EventHandler(this.tsbtnInsertPicture_Click);
            // 
            // tsbtnZoomIn
            // 
            this.tsbtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomIn.Image")));
            this.tsbtnZoomIn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnZoomIn.Name = "tsbtnZoomIn";
            this.tsbtnZoomIn.Size = new System.Drawing.Size(23, 23);
            this.tsbtnZoomIn.Text = "toolStripButton1";
            this.tsbtnZoomIn.ToolTipText = "Zoom In";
            this.tsbtnZoomIn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnZoomOut
            // 
            this.tsbtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomOut.Image")));
            this.tsbtnZoomOut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnZoomOut.Name = "tsbtnZoomOut";
            this.tsbtnZoomOut.Size = new System.Drawing.Size(23, 23);
            this.tsbtnZoomOut.Text = "toolStripButton2";
            this.tsbtnZoomOut.ToolTipText = "Zoom Out";
            this.tsbtnZoomOut.Click += new System.EventHandler(this.tsbtnZoomOut_Click);
            // 
            // RicherTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbDocument);
            this.Controls.Add(this.toolStripFindReplace);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RicherTextBox";
            this.Size = new System.Drawing.Size(667, 313);
            this.Load += new System.EventHandler(this.RicherTextBox_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.toolStripFindReplace.ResumeLayout(false);
            this.toolStripFindReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDocument;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripButton tsbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbtnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAlignLeft;
        private System.Windows.Forms.ToolStripButton tsbtnAlignCenter;
        private System.Windows.Forms.ToolStripButton tsbtnAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnFontColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnIndent;
        private System.Windows.Forms.ToolStripButton tsbtnBullets;
        private System.Windows.Forms.ToolStripButton tsbtnOutdent;
        private System.Windows.Forms.ToolStripComboBox tscmbFontSize;
        private System.Windows.Forms.ToolStripButton tsbtnChooseFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnInsertPicture;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbtnZoomIn;
        private System.Windows.Forms.ToolStripButton tsbtnZoomOut;
        private System.Windows.Forms.ToolStripTextBox tstxtZoomFactor;
        private System.Windows.Forms.ToolStripButton tsbtnWordWrap;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem insertPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripFindReplace;
        private System.Windows.Forms.ToolStripTextBox tstxtSearchText;
        private System.Windows.Forms.ToolStripButton tsbtnFind;
        private System.Windows.Forms.ToolStripButton tsbtnReplace;

    }
}
