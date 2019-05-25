namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDrawButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilePngButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImage = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.colorButton = new System.Windows.Forms.ToolStripSplitButton();
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pickUpButton = new System.Windows.Forms.ToolStripButton();
            this.eraseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.penWidthPicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.widthPicker = new System.Windows.Forms.NumericUpDown();
            this.heightPicker = new System.Windows.Forms.NumericUpDown();
            this.transparencyPicker = new System.Windows.Forms.NumericUpDown();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.rotationPicker = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.heartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.starButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.zoomInfoLabel = new System.Windows.Forms.Label();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPicker)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(65)))), ((int)(((byte)(82)))));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(885, 29);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton,
            this.exitToolStripMenuItem});
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(46, 25);
            this.fileButton.Text = "File";
            // 
            // openFileButton
            // 
            this.openFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDrawButton,
            this.openFilePngButton});
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(152, 26);
            this.openFileButton.Text = "Open file...";
            // 
            // openFileDrawButton
            // 
            this.openFileDrawButton.Name = "openFileDrawButton";
            this.openFileDrawButton.Size = new System.Drawing.Size(118, 26);
            this.openFileDrawButton.Text = ".draw";
            this.openFileDrawButton.Click += new System.EventHandler(this.openFileDrawButton_Click);
            // 
            // openFilePngButton
            // 
            this.openFilePngButton.Name = "openFilePngButton";
            this.openFilePngButton.Size = new System.Drawing.Size(118, 26);
            this.openFilePngButton.Text = ".png";
            this.openFilePngButton.Click += new System.EventHandler(this.openFilePngButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem1,
            this.pngToolStripMenuItem1});
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(152, 26);
            this.saveFileButton.Text = "Save as...";
            // 
            // drawToolStripMenuItem1
            // 
            this.drawToolStripMenuItem1.Name = "drawToolStripMenuItem1";
            this.drawToolStripMenuItem1.Size = new System.Drawing.Size(118, 26);
            this.drawToolStripMenuItem1.Text = ".draw";
            this.drawToolStripMenuItem1.Click += new System.EventHandler(this.saveFileAsDrawButton_Click);
            // 
            // pngToolStripMenuItem1
            // 
            this.pngToolStripMenuItem1.Name = "pngToolStripMenuItem1";
            this.pngToolStripMenuItem1.Size = new System.Drawing.Size(118, 26);
            this.pngToolStripMenuItem1.Text = ".png";
            this.pngToolStripMenuItem1.Click += new System.EventHandler(this.saveFileAsPngButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuButton);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelActionToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cancelActionToolStripMenuItem
            // 
            this.cancelActionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelActionToolStripMenuItem.Image")));
            this.cancelActionToolStripMenuItem.Name = "cancelActionToolStripMenuItem";
            this.cancelActionToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.cancelActionToolStripMenuItem.Text = "Cancel action";
            this.cancelActionToolStripMenuItem.Click += new System.EventHandler(this.cancelActionButton_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImage});
            this.imageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // addImage
            // 
            this.addImage.Image = ((System.Drawing.Image)(resources.GetObject("addImage.Image")));
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(155, 26);
            this.addImage.Text = "Add image";
            this.addImage.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 542);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(885, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.AutoSize = false;
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.ForeColor = System.Drawing.Color.White;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(45, 35);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.ToolTipText = "pickUpButton";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Crimson;
            this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorButton.DropDownButtonWidth = 15;
            this.colorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderColorToolStripMenuItem,
            this.fillColorToolStripMenuItem});
            this.colorButton.ForeColor = System.Drawing.Color.Black;
            this.colorButton.Image = ((System.Drawing.Image)(resources.GetObject("colorButton.Image")));
            this.colorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.colorButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.colorButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.colorButton.Name = "colorButton";
            this.colorButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.colorButton.Padding = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.colorButton.Size = new System.Drawing.Size(53, 19);
            this.colorButton.Text = "Color";
            this.colorButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.colorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.borderColorToolStripMenuItem.Text = "Border color";
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // fillColorToolStripMenuItem
            // 
            this.fillColorToolStripMenuItem.Name = "fillColorToolStripMenuItem";
            this.fillColorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fillColorToolStripMenuItem.Text = "Fill color";
            this.fillColorToolStripMenuItem.Click += new System.EventHandler(this.fillColorButton_Click);
            // 
            // speedMenu
            // 
            this.speedMenu.AutoSize = false;
            this.speedMenu.BackColor = System.Drawing.Color.Tan;
            this.speedMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.speedMenu.CanOverflow = false;
            this.speedMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.speedMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.pickUpSpeedButton,
            this.pickUpButton,
            this.eraseButton,
            this.toolStripSeparator4,
            this.colorButton,
            this.toolStripSeparator3});
            this.speedMenu.Location = new System.Drawing.Point(0, 29);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.speedMenu.Size = new System.Drawing.Size(55, 513);
            this.speedMenu.TabIndex = 5;
            this.speedMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(53, 6);
            // 
            // toolStripButton1
            // 
            this.pickUpButton.AutoSize = false;
            this.pickUpButton.CheckOnClick = true;
            this.pickUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.pickUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpButton.Name = "toolStripButton1";
            this.pickUpButton.Size = new System.Drawing.Size(45, 35);
            this.pickUpButton.Text = "toolStripButton1";
            this.pickUpButton.Click += new System.EventHandler(this.drawButton);
            // 
            // eraseButton
            // 
            this.eraseButton.AutoSize = false;
            this.eraseButton.CheckOnClick = true;
            this.eraseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseButton.Image = ((System.Drawing.Image)(resources.GetObject("eraseButton.Image")));
            this.eraseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(45, 35);
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(53, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(53, 6);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.Location = new System.Drawing.Point(8, 204);
            this.colorBox.Margin = new System.Windows.Forms.Padding(1);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(32, 32);
            this.colorBox.TabIndex = 5;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // penWidthPicker
            // 
            this.penWidthPicker.Location = new System.Drawing.Point(205, 31);
            this.penWidthPicker.Name = "penWidthPicker";
            this.penWidthPicker.Size = new System.Drawing.Size(49, 20);
            this.penWidthPicker.TabIndex = 7;
            this.penWidthPicker.ValueChanged += new System.EventHandler(this.penWidthPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(-13700, -3259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "info: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(131, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "border width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(260, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(370, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(479, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "transparency:";
            // 
            // widthPicker
            // 
            this.widthPicker.Location = new System.Drawing.Point(301, 31);
            this.widthPicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthPicker.Name = "widthPicker";
            this.widthPicker.Size = new System.Drawing.Size(63, 20);
            this.widthPicker.TabIndex = 15;
            this.widthPicker.ValueChanged += new System.EventHandler(this.widthPicker_ValueChanged);
            // 
            // heightPicker
            // 
            this.heightPicker.Location = new System.Drawing.Point(415, 31);
            this.heightPicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightPicker.Name = "heightPicker";
            this.heightPicker.Size = new System.Drawing.Size(58, 20);
            this.heightPicker.TabIndex = 16;
            this.heightPicker.ValueChanged += new System.EventHandler(this.heightPicker_ValueChanged);
            // 
            // transparencyPicker
            // 
            this.transparencyPicker.Location = new System.Drawing.Point(556, 31);
            this.transparencyPicker.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.transparencyPicker.Name = "transparencyPicker";
            this.transparencyPicker.Size = new System.Drawing.Size(43, 20);
            this.transparencyPicker.TabIndex = 17;
            this.transparencyPicker.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.transparencyPicker.ValueChanged += new System.EventHandler(this.transparencyPicker_ValueChanged);
            // 
            // zoomLabel
            // 
            this.zoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.BackColor = System.Drawing.Color.Tan;
            this.zoomLabel.Location = new System.Drawing.Point(2, -3129);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(40, 13);
            this.zoomLabel.TabIndex = 18;
            this.zoomLabel.Text = "Zoom: ";
            // 
            // rotationPicker
            // 
            this.rotationPicker.Location = new System.Drawing.Point(646, 31);
            this.rotationPicker.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationPicker.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotationPicker.Name = "rotationPicker";
            this.rotationPicker.Size = new System.Drawing.Size(43, 20);
            this.rotationPicker.TabIndex = 21;
            this.rotationPicker.ValueChanged += new System.EventHandler(this.rotationPicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(605, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "rotation:";
            // 
            // shapeButton
            // 
            this.shapeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineButton,
            this.rectangleButton,
            this.ellipseButton,
            this.heartButton,
            this.starButton});
            this.shapeButton.Image = ((System.Drawing.Image)(resources.GetObject("shapeButton.Image")));
            this.shapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shapeButton.Name = "shapeButton";
            this.shapeButton.Size = new System.Drawing.Size(72, 30);
            this.shapeButton.Text = "Shape";
            this.shapeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // lineButton
            // 
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(126, 22);
            this.lineButton.Text = "Line";
            this.lineButton.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(126, 22);
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(126, 22);
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // heartButton
            // 
            this.heartButton.Image = ((System.Drawing.Image)(resources.GetObject("heartButton.Image")));
            this.heartButton.Name = "heartButton";
            this.heartButton.Size = new System.Drawing.Size(126, 22);
            this.heartButton.Text = "Heart";
            this.heartButton.Click += new System.EventHandler(this.starToolStripMenuItem_Click);
            // 
            // starButton
            // 
            this.starButton.Image = ((System.Drawing.Image)(resources.GetObject("starButton.Image")));
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(126, 22);
            this.starButton.Text = "Star";
            this.starButton.Click += new System.EventHandler(this.starToolStripMenuItem_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Tan;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeButton});
            this.toolStrip1.Location = new System.Drawing.Point(55, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(830, 33);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.viewPort);
            this.panel1.Location = new System.Drawing.Point(55, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 487);
            this.panel1.TabIndex = 0;
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.BackColor = System.Drawing.Color.SlateGray;
            this.layoutPanel.Controls.Add(this.infoLabel);
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(646, 55);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(239, 484);
            this.layoutPanel.TabIndex = 24;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "label8";
            // 
            // zoomInfoLabel
            // 
            this.zoomInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomInfoLabel.BackColor = System.Drawing.Color.Tan;
            this.zoomInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zoomInfoLabel.Location = new System.Drawing.Point(0, 489);
            this.zoomInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zoomInfoLabel.Name = "zoomInfoLabel";
            this.zoomInfoLabel.Size = new System.Drawing.Size(55, 34);
            this.zoomInfoLabel.TabIndex = 25;
            this.zoomInfoLabel.Text = "Zoom: \r\n1x";
            // 
            // viewPort
            // 
            this.viewPort.AutoScroll = true;
            this.viewPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPort.BackColor = System.Drawing.Color.White;
            this.viewPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPort.Cursor = System.Windows.Forms.Cursors.Cross;
            this.viewPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewPort.Location = new System.Drawing.Point(0, 0);
            this.viewPort.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.viewPort.MinimumSize = new System.Drawing.Size(480, 720);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1280, 720);
            this.viewPort.TabIndex = 6;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViewPort_KeyPress);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 564);
            this.Controls.Add(this.zoomInfoLabel);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.rotationPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.transparencyPicker);
            this.Controls.Add(this.heightPicker);
            this.Controls.Add(this.widthPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.penWidthPicker);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPicker)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileButton;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
        private System.Windows.Forms.ToolStripSplitButton colorButton;
        private System.Windows.Forms.ToolStrip speedMenu;
        private System.Windows.Forms.ToolStripButton pickUpButton;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fillColorToolStripMenuItem;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.NumericUpDown penWidthPicker;
        private System.Windows.Forms.ToolStripButton eraseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown widthPicker;
        private System.Windows.Forms.NumericUpDown heightPicker;
        private System.Windows.Forms.NumericUpDown transparencyPicker;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.ToolStripMenuItem addImage;
        private System.Windows.Forms.ToolStripMenuItem cancelActionToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown rotationPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripDropDownButton shapeButton;
        private System.Windows.Forms.ToolStripMenuItem lineButton;
        private System.Windows.Forms.ToolStripMenuItem rectangleButton;
        private System.Windows.Forms.ToolStripMenuItem ellipseButton;
        private System.Windows.Forms.ToolStripMenuItem heartButton;
        private System.Windows.Forms.ToolStripMenuItem starButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private DoubleBufferedPanel viewPort;
        private System.Windows.Forms.Label zoomInfoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripMenuItem saveFileButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripMenuItem openFileDrawButton;
        private System.Windows.Forms.ToolStripMenuItem openFilePngButton;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pngToolStripMenuItem1;
    }
}
