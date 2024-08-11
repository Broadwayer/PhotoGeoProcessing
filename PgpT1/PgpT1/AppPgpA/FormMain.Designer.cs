using System.Windows.Forms.VisualStyles;

namespace AppPgpA
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._toolStripMain = new System.Windows.Forms.ToolStrip();
            this._loadLeftImageBtn = new System.Windows.Forms.ToolStripButton();
            this._loadRightImageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._leftImageZoomInBtn = new System.Windows.Forms.ToolStripButton();
            this._leftImageZoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this._leftImageResetZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._rightImageZoomInBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImageZoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImageResetZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._syncByLeftImageBtn = new System.Windows.Forms.ToolStripButton();
            this._syncByRightImageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._leftImageMoveBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImageMoveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this._displayLeftImagePoints = new System.Windows.Forms.ToolStripButton();
            this._displayRightImagePoints = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._bmpLeftPointsLoad = new System.Windows.Forms.ToolStripButton();
            this._bmpLeftPointsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._bmpRightPointsLoad = new System.Windows.Forms.ToolStripButton();
            this._bmpRightPointsSave = new System.Windows.Forms.ToolStripButton();
            this._basisTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._procStereoPairBtn = new System.Windows.Forms.ToolStripButton();
            this._statusStripMain = new System.Windows.Forms.StatusStrip();
            this._splitContainerMain = new System.Windows.Forms.SplitContainer();
            this._splitContainerImages = new System.Windows.Forms.SplitContainer();
            this._stereoPairSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this._createNewStereoPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._loadStereoPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._stereoPairSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).BeginInit();
            this._splitContainerMain.Panel1.SuspendLayout();
            this._splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerImages)).BeginInit();
            this._splitContainerImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStripMain
            // 
            this._toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._loadLeftImageBtn,
            this._loadRightImageBtn,
            this.toolStripSeparator1,
            this._leftImageZoomInBtn,
            this._leftImageZoomOutBtn,
            this._leftImageResetZoomBtn,
            this.toolStripSeparator2,
            this._rightImageZoomInBtn,
            this._rightImageZoomOutBtn,
            this._rightImageResetZoomBtn,
            this.toolStripSeparator3,
            this._syncByLeftImageBtn,
            this._syncByRightImageBtn,
            this.toolStripSeparator4,
            this._leftImageMoveBtn,
            this._rightImageMoveBtn,
            this.toolStripSeparator5,
            this._displayLeftImagePoints,
            this._displayRightImagePoints,
            this.toolStripSeparator6,
            this._bmpLeftPointsLoad,
            this._bmpLeftPointsSave,
            this.toolStripSeparator7,
            this._bmpRightPointsLoad,
            this._bmpRightPointsSave,
            this._basisTextBox,
            this._procStereoPairBtn,
            this._stereoPairSplitButton});
            this._toolStripMain.Location = new System.Drawing.Point(0, 0);
            this._toolStripMain.Name = "_toolStripMain";
            this._toolStripMain.Size = new System.Drawing.Size(1660, 33);
            this._toolStripMain.TabIndex = 0;
            this._toolStripMain.Text = "toolStripMain";
            // 
            // _loadLeftImageBtn
            // 
            this._loadLeftImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._loadLeftImageBtn.Image = global::AppPgpA.UIImagesResource.LoadImageLeft;
            this._loadLeftImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._loadLeftImageBtn.Name = "_loadLeftImageBtn";
            this._loadLeftImageBtn.Size = new System.Drawing.Size(34, 28);
            this._loadLeftImageBtn.ToolTipText = global::AppPgpA.UIStrings.LoadLeftImage;
            this._loadLeftImageBtn.Click += new System.EventHandler(this._loadLeftImageBtn_Click);
            // 
            // _loadRightImageBtn
            // 
            this._loadRightImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._loadRightImageBtn.Image = global::AppPgpA.UIImagesResource.LoadImageRight;
            this._loadRightImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._loadRightImageBtn.Name = "_loadRightImageBtn";
            this._loadRightImageBtn.Size = new System.Drawing.Size(34, 28);
            this._loadRightImageBtn.ToolTipText = global::AppPgpA.UIStrings.LoadRightImage;
            this._loadRightImageBtn.Click += new System.EventHandler(this._loadRightImageBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // _leftImageZoomInBtn
            // 
            this._leftImageZoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageZoomInBtn.Image = global::AppPgpA.UIImagesResource.ZoomInLeft;
            this._leftImageZoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageZoomInBtn.Name = "_leftImageZoomInBtn";
            this._leftImageZoomInBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageZoomInBtn.ToolTipText = global::AppPgpA.UIStrings.LeftImageZoomIn;
            this._leftImageZoomInBtn.Click += new System.EventHandler(this._leftImageZoomInBtn_Click);
            // 
            // _leftImageZoomOutBtn
            // 
            this._leftImageZoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageZoomOutBtn.Image = global::AppPgpA.UIImagesResource.ZoomOutLeft;
            this._leftImageZoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageZoomOutBtn.Name = "_leftImageZoomOutBtn";
            this._leftImageZoomOutBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageZoomOutBtn.ToolTipText = global::AppPgpA.UIStrings.LeftImageZoomOut;
            this._leftImageZoomOutBtn.Click += new System.EventHandler(this._leftImageZoomOutBtn_Click);
            // 
            // _leftImageResetZoomBtn
            // 
            this._leftImageResetZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageResetZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImageResetZoomBtn.Image")));
            this._leftImageResetZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageResetZoomBtn.Name = "_leftImageResetZoomBtn";
            this._leftImageResetZoomBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageResetZoomBtn.ToolTipText = global::AppPgpA.UIStrings.LeftImageResetZoom;
            this._leftImageResetZoomBtn.Click += new System.EventHandler(this._leftImageResetZoomBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // _rightImageZoomInBtn
            // 
            this._rightImageZoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageZoomInBtn.Image = global::AppPgpA.UIImagesResource.ZoomInRight;
            this._rightImageZoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageZoomInBtn.Name = "_rightImageZoomInBtn";
            this._rightImageZoomInBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageZoomInBtn.ToolTipText = global::AppPgpA.UIStrings.RightImageZoomIn;
            this._rightImageZoomInBtn.Click += new System.EventHandler(this._rightImageZoomInBtn_Click);
            // 
            // _rightImageZoomOutBtn
            // 
            this._rightImageZoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageZoomOutBtn.Image = global::AppPgpA.UIImagesResource.ZoomOutRight;
            this._rightImageZoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageZoomOutBtn.Name = "_rightImageZoomOutBtn";
            this._rightImageZoomOutBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageZoomOutBtn.ToolTipText = global::AppPgpA.UIStrings.RightImageZoomOut;
            this._rightImageZoomOutBtn.Click += new System.EventHandler(this._rightImageZoomOutBtn_Click);
            // 
            // _rightImageResetZoomBtn
            // 
            this._rightImageResetZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageResetZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImageResetZoomBtn.Image")));
            this._rightImageResetZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageResetZoomBtn.Name = "_rightImageResetZoomBtn";
            this._rightImageResetZoomBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageResetZoomBtn.ToolTipText = global::AppPgpA.UIStrings.RightImageResetZoom;
            this._rightImageResetZoomBtn.Click += new System.EventHandler(this._rightImageResetZoomBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // _syncByLeftImageBtn
            // 
            this._syncByLeftImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._syncByLeftImageBtn.Image = global::AppPgpA.UIImagesResource.SynchronizeToLeft;
            this._syncByLeftImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._syncByLeftImageBtn.Name = "_syncByLeftImageBtn";
            this._syncByLeftImageBtn.Size = new System.Drawing.Size(34, 28);
            this._syncByLeftImageBtn.ToolTipText = global::AppPgpA.UIStrings.SyncByLeftImage;
            this._syncByLeftImageBtn.Click += new System.EventHandler(this._syncByLeftImageBtn_Click);
            // 
            // _syncByRightImageBtn
            // 
            this._syncByRightImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._syncByRightImageBtn.Image = global::AppPgpA.UIImagesResource.SynchronizeToRight;
            this._syncByRightImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._syncByRightImageBtn.Name = "_syncByRightImageBtn";
            this._syncByRightImageBtn.Size = new System.Drawing.Size(34, 28);
            this._syncByRightImageBtn.ToolTipText = global::AppPgpA.UIStrings.SyncByRightImage;
            this._syncByRightImageBtn.Click += new System.EventHandler(this._syncByRightImageBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // _leftImageMoveBtn
            // 
            this._leftImageMoveBtn.CheckOnClick = true;
            this._leftImageMoveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageMoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImageMoveBtn.Image")));
            this._leftImageMoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageMoveBtn.Name = "_leftImageMoveBtn";
            this._leftImageMoveBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageMoveBtn.ToolTipText = global::AppPgpA.UIStrings.PanLeftImage;
            // 
            // _rightImageMoveBtn
            // 
            this._rightImageMoveBtn.CheckOnClick = true;
            this._rightImageMoveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageMoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImageMoveBtn.Image")));
            this._rightImageMoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageMoveBtn.Name = "_rightImageMoveBtn";
            this._rightImageMoveBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageMoveBtn.ToolTipText = global::AppPgpA.UIStrings.PanRightImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // _displayLeftImagePoints
            // 
            this._displayLeftImagePoints.CheckOnClick = true;
            this._displayLeftImagePoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._displayLeftImagePoints.Image = ((System.Drawing.Image)(resources.GetObject("_displayLeftImagePoints.Image")));
            this._displayLeftImagePoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._displayLeftImagePoints.Name = "_displayLeftImagePoints";
            this._displayLeftImagePoints.Size = new System.Drawing.Size(34, 28);
            this._displayLeftImagePoints.ToolTipText = global::AppPgpA.UIStrings.DisplayLeftImagePoints;
            this._displayLeftImagePoints.CheckStateChanged += new System.EventHandler(this._displayLeftImagePoints_CheckStateChanged);
            // 
            // _displayRightImagePoints
            // 
            this._displayRightImagePoints.CheckOnClick = true;
            this._displayRightImagePoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._displayRightImagePoints.Image = ((System.Drawing.Image)(resources.GetObject("_displayRightImagePoints.Image")));
            this._displayRightImagePoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._displayRightImagePoints.Name = "_displayRightImagePoints";
            this._displayRightImagePoints.Size = new System.Drawing.Size(34, 28);
            this._displayRightImagePoints.ToolTipText = global::AppPgpA.UIStrings.DisplayRightImagePoints;
            this._displayRightImagePoints.CheckStateChanged += new System.EventHandler(this._displayRightImagePoints_CheckStateChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // _bmpLeftPointsLoad
            // 
            this._bmpLeftPointsLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bmpLeftPointsLoad.Image = global::AppPgpA.UIImagesResource.LoadPointsLeft;
            this._bmpLeftPointsLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bmpLeftPointsLoad.Name = "_bmpLeftPointsLoad";
            this._bmpLeftPointsLoad.Size = new System.Drawing.Size(34, 28);
            this._bmpLeftPointsLoad.ToolTipText = global::AppPgpA.UIStrings.LoadSelectedPointsLeftImage;
            this._bmpLeftPointsLoad.Click += new System.EventHandler(this._bmpLeftPointsLoad_Click);
            // 
            // _bmpLeftPointsSave
            // 
            this._bmpLeftPointsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bmpLeftPointsSave.Image = global::AppPgpA.UIImagesResource.SavePointsLeft;
            this._bmpLeftPointsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bmpLeftPointsSave.Name = "_bmpLeftPointsSave";
            this._bmpLeftPointsSave.Size = new System.Drawing.Size(34, 28);
            this._bmpLeftPointsSave.ToolTipText = global::AppPgpA.UIStrings.SaveSelectedPointsLeftImage;
            this._bmpLeftPointsSave.Click += new System.EventHandler(this._bmpLeftPointsSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // _bmpRightPointsLoad
            // 
            this._bmpRightPointsLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bmpRightPointsLoad.Image = global::AppPgpA.UIImagesResource.LoadPointsRight;
            this._bmpRightPointsLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bmpRightPointsLoad.Name = "_bmpRightPointsLoad";
            this._bmpRightPointsLoad.Size = new System.Drawing.Size(34, 28);
            this._bmpRightPointsLoad.ToolTipText = global::AppPgpA.UIStrings.LoadSelectedPointsRightImage;
            this._bmpRightPointsLoad.Click += new System.EventHandler(this._bmpRightPointsLoad_Click);
            // 
            // _bmpRightPointsSave
            // 
            this._bmpRightPointsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bmpRightPointsSave.Image = global::AppPgpA.UIImagesResource.SavePointsRight;
            this._bmpRightPointsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bmpRightPointsSave.Name = "_bmpRightPointsSave";
            this._bmpRightPointsSave.Size = new System.Drawing.Size(34, 28);
            this._bmpRightPointsSave.ToolTipText = global::AppPgpA.UIStrings.SaveSelectedPointsRightImage;
            this._bmpRightPointsSave.Click += new System.EventHandler(this._bmpRightPointsSave_Click);
            // 
            // _basisTextBox
            // 
            this._basisTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._basisTextBox.Name = "_basisTextBox";
            this._basisTextBox.Size = new System.Drawing.Size(100, 33);
            this._basisTextBox.ToolTipText = global::AppPgpA.UIStrings.Basis;
            this._basisTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._basisTextBox_KeyDown);
            this._basisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._basisTextBox_KeyPress);
            this._basisTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this._basisTextBox_KeyUp);
            // 
            // _procStereoPairBtn
            // 
            this._procStereoPairBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._procStereoPairBtn.Image = ((System.Drawing.Image)(resources.GetObject("_procStereoPairBtn.Image")));
            this._procStereoPairBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._procStereoPairBtn.Name = "_procStereoPairBtn";
            this._procStereoPairBtn.Size = new System.Drawing.Size(34, 28);
            this._procStereoPairBtn.ToolTipText = global::AppPgpA.UIStrings.ProcStereoPair;
            this._procStereoPairBtn.Click += new System.EventHandler(this._procStereoPairBtn_Click);
            // 
            // _statusStripMain
            // 
            this._statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._statusStripMain.Location = new System.Drawing.Point(0, 745);
            this._statusStripMain.Name = "_statusStripMain";
            this._statusStripMain.Size = new System.Drawing.Size(1660, 22);
            this._statusStripMain.TabIndex = 1;
            this._statusStripMain.Text = "statusStrip1";
            // 
            // _splitContainerMain
            // 
            this._splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerMain.Location = new System.Drawing.Point(0, 33);
            this._splitContainerMain.Name = "_splitContainerMain";
            this._splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerMain.Panel1
            // 
            this._splitContainerMain.Panel1.Controls.Add(this._splitContainerImages);
            // 
            // _splitContainerMain.Panel2
            // 
            this._splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._splitContainerMain.Size = new System.Drawing.Size(1660, 712);
            this._splitContainerMain.SplitterDistance = 544;
            this._splitContainerMain.TabIndex = 2;
            // 
            // _splitContainerImages
            // 
            this._splitContainerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerImages.Location = new System.Drawing.Point(0, 0);
            this._splitContainerImages.Name = "_splitContainerImages";
            // 
            // _splitContainerImages.Panel1
            // 
            this._splitContainerImages.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._splitContainerImages.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this._splitContainerImages_Panel1_Paint);
            this._splitContainerImages.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._splitContainerImages_Panel1_MouseDown);
            this._splitContainerImages.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this._splitContainerImages_Panel1_MouseMove);
            // 
            // _splitContainerImages.Panel2
            // 
            this._splitContainerImages.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._splitContainerImages.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this._splitContainerImages_Panel2_Paint);
            this._splitContainerImages.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._splitContainerImages_Panel2_MouseDown);
            this._splitContainerImages.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this._splitContainerImages_Panel2_MouseMove);
            this._splitContainerImages.Size = new System.Drawing.Size(1660, 544);
            this._splitContainerImages.SplitterDistance = 553;
            this._splitContainerImages.TabIndex = 0;
            // 
            // _stereoPairSplitButton
            // 
            this._stereoPairSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._stereoPairSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._createNewStereoPairToolStripMenuItem,
            this._loadStereoPairToolStripMenuItem,
            this._stereoPairSettingsToolStripMenuItem});
            this._stereoPairSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("_stereoPairSplitButton.Image")));
            this._stereoPairSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._stereoPairSplitButton.Name = "_stereoPairSplitButton";
            this._stereoPairSplitButton.Size = new System.Drawing.Size(45, 28);
            this._stereoPairSplitButton.Text = "toolStripSplitButton1";
            // 
            // _createNewStereoPairToolStripMenuItem
            // 
            this._createNewStereoPairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._createNewStereoPairToolStripMenuItem.Name = "_createNewStereoPairToolStripMenuItem";
            this._createNewStereoPairToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this._createNewStereoPairToolStripMenuItem.Text = "Create new stereo pair";
            this._createNewStereoPairToolStripMenuItem.Click += new System.EventHandler(this._createNewStereoPairToolStripMenuItem_Click);
            // 
            // _loadStereoPairToolStripMenuItem
            // 
            this._loadStereoPairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._loadStereoPairToolStripMenuItem.Name = "_loadStereoPairToolStripMenuItem";
            this._loadStereoPairToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this._loadStereoPairToolStripMenuItem.Text = "Load stereo pair";
            this._loadStereoPairToolStripMenuItem.Click += new System.EventHandler(this._loadStereoPairToolStripMenuItem_Click);
            // 
            // _stereoPairSettingsToolStripMenuItem
            // 
            this._stereoPairSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._stereoPairSettingsToolStripMenuItem.Name = "_stereoPairSettingsToolStripMenuItem";
            this._stereoPairSettingsToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this._stereoPairSettingsToolStripMenuItem.Text = "Stereo pair settings";
            this._stereoPairSettingsToolStripMenuItem.Click += new System.EventHandler(this._stereoPairSettingsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 767);
            this.Controls.Add(this._splitContainerMain);
            this.Controls.Add(this._statusStripMain);
            this.Controls.Add(this._toolStripMain);
            this.Name = "FormMain";
            this.Text = "Form1";
            this._toolStripMain.ResumeLayout(false);
            this._toolStripMain.PerformLayout();
            this._splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).EndInit();
            this._splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerImages)).EndInit();
            this._splitContainerImages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolStripMain;
        private System.Windows.Forms.StatusStrip _statusStripMain;
        private System.Windows.Forms.SplitContainer _splitContainerMain;
        private System.Windows.Forms.SplitContainer _splitContainerImages;
        private System.Windows.Forms.ToolStripButton _loadLeftImageBtn;
        private System.Windows.Forms.ToolStripButton _loadRightImageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _leftImageZoomInBtn;
        private System.Windows.Forms.ToolStripButton _leftImageZoomOutBtn;
        private System.Windows.Forms.ToolStripButton _leftImageResetZoomBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _rightImageZoomInBtn;
        private System.Windows.Forms.ToolStripButton _rightImageZoomOutBtn;
        private System.Windows.Forms.ToolStripButton _rightImageResetZoomBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _syncByLeftImageBtn;
        private System.Windows.Forms.ToolStripButton _syncByRightImageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton _leftImageMoveBtn;
        private System.Windows.Forms.ToolStripButton _rightImageMoveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _displayLeftImagePoints;
        private System.Windows.Forms.ToolStripButton _displayRightImagePoints;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton _bmpLeftPointsLoad;
        private System.Windows.Forms.ToolStripButton _bmpLeftPointsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton _bmpRightPointsLoad;
        private System.Windows.Forms.ToolStripButton _bmpRightPointsSave;
        private System.Windows.Forms.ToolStripButton _procStereoPairBtn;
        private System.Windows.Forms.ToolStripTextBox _basisTextBox;
        private System.Windows.Forms.ToolStripSplitButton _stereoPairSplitButton;
        private System.Windows.Forms.ToolStripMenuItem _createNewStereoPairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _loadStereoPairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _stereoPairSettingsToolStripMenuItem;
    }
}

