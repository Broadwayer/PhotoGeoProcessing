namespace AppPgpA001
{
    partial class StereoPairViewControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StereoPairViewControl));
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._leftImageZoomInBtn = new System.Windows.Forms.ToolStripButton();
            this._leftImageZoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this._leftImageResetZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._rightImageZoomInBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImageZoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImageResetZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._syncByLeftImageBtn = new System.Windows.Forms.ToolStripButton();
            this._syncByRightImageBtn = new System.Windows.Forms.ToolStripButton();
            this._syncPanelWidth = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._leftImagePanBtn = new System.Windows.Forms.ToolStripButton();
            this._rightImagePanBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._stereoPairSettings = new System.Windows.Forms.ToolStripButton();
            this._imagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this._mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imagesSplitContainer)).BeginInit();
            this._imagesSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._leftImageZoomInBtn,
            this._leftImageZoomOutBtn,
            this._leftImageResetZoomBtn,
            this.toolStripSeparator1,
            this._rightImageZoomInBtn,
            this._rightImageZoomOutBtn,
            this._rightImageResetZoomBtn,
            this.toolStripSeparator2,
            this._syncByLeftImageBtn,
            this._syncByRightImageBtn,
            this._syncPanelWidth,
            this.toolStripSeparator3,
            this._leftImagePanBtn,
            this._rightImagePanBtn,
            this.toolStripSeparator4,
            this._stereoPairSettings});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(1316, 33);
            this._mainToolStrip.TabIndex = 0;
            this._mainToolStrip.Text = "";
            // 
            // _leftImageZoomInBtn
            // 
            this._leftImageZoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageZoomInBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImageZoomInBtn.Image")));
            this._leftImageZoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageZoomInBtn.Name = "_leftImageZoomInBtn";
            this._leftImageZoomInBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageZoomInBtn.Click += new System.EventHandler(this._leftImageZoomInBtn_Click);
            this._leftImageZoomInBtn.ToolTipText = UIStrings.LeftImageZoomIn;
            // 
            // _leftImageZoomOutBtn
            // 
            this._leftImageZoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageZoomOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImageZoomOutBtn.Image")));
            this._leftImageZoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageZoomOutBtn.Name = "_leftImageZoomOutBtn";
            this._leftImageZoomOutBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageZoomOutBtn.Text = "toolStripButton2";
            this._leftImageZoomOutBtn.Click += new System.EventHandler(this._leftImageZoomOutBtn_Click);
            this._leftImageZoomOutBtn.ToolTipText = UIStrings.LeftImageZoomOut;
            // 
            // _leftImageResetZoomBtn
            // 
            this._leftImageResetZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImageResetZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImageResetZoomBtn.Image")));
            this._leftImageResetZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImageResetZoomBtn.Name = "_leftImageResetZoomBtn";
            this._leftImageResetZoomBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImageResetZoomBtn.Text = "toolStripButton3";
            this._leftImageResetZoomBtn.Click += new System.EventHandler(this._leftImageResetZoomBtn_Click);
            this._leftImageResetZoomBtn.ToolTipText = UIStrings.LeftImageResetZoom;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // _rightImageZoomInBtn
            // 
            this._rightImageZoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageZoomInBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImageZoomInBtn.Image")));
            this._rightImageZoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageZoomInBtn.Name = "_rightImageZoomInBtn";
            this._rightImageZoomInBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageZoomInBtn.Click += new System.EventHandler(this._rightImageZoomInBtn_Click);
            this._rightImageZoomInBtn.ToolTipText = UIStrings.RightImageZoomIn;
            // 
            // _rightImageZoomOutBtn
            // 
            this._rightImageZoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageZoomOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImageZoomOutBtn.Image")));
            this._rightImageZoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageZoomOutBtn.Name = "_rightImageZoomOutBtn";
            this._rightImageZoomOutBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageZoomOutBtn.Click += new System.EventHandler(this._rightImageZoomOutBtn_Click);
            this._rightImageZoomOutBtn.ToolTipText = UIStrings.RightImageZoomOut;
            // 
            // _rightImageResetZoomBtn
            // 
            this._rightImageResetZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImageResetZoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImageResetZoomBtn.Image")));
            this._rightImageResetZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImageResetZoomBtn.Name = "_rightImageResetZoomBtn";
            this._rightImageResetZoomBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImageResetZoomBtn.Click += new System.EventHandler(this._rightImageResetZoomBtn_Click);
            this._rightImageResetZoomBtn.ToolTipText = UIStrings.RightImageResetZoom;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // _syncByLeftImageBtn
            // 
            this._syncByLeftImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._syncByLeftImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("_syncByLeftImageBtn.Image")));
            this._syncByLeftImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._syncByLeftImageBtn.Name = "_syncByLeftImageBtn";
            this._syncByLeftImageBtn.Size = new System.Drawing.Size(34, 28);
            this._syncByLeftImageBtn.Click += new System.EventHandler(this._syncByLeftImageBtn_Click);
            this._syncByLeftImageBtn.ToolTipText = UIStrings.SyncByLeftImage;
            // 
            // _syncByRightImageBtn
            // 
            this._syncByRightImageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._syncByRightImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("_syncByRightImageBtn.Image")));
            this._syncByRightImageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._syncByRightImageBtn.Name = "_syncByRightImageBtn";
            this._syncByRightImageBtn.Size = new System.Drawing.Size(34, 28);
            this._syncByRightImageBtn.Click += new System.EventHandler(this._syncByRightImageBtn_Click);
            this._syncByRightImageBtn.ToolTipText = UIStrings.SyncByRightImage;
            // 
            // _syncPanelWidth
            // 
            this._syncPanelWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._syncPanelWidth.Image = ((System.Drawing.Image)(resources.GetObject("_syncPanelWidth.Image")));
            this._syncPanelWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._syncPanelWidth.Name = "_syncPanelWidth";
            this._syncPanelWidth.Size = new System.Drawing.Size(34, 28);
            this._syncPanelWidth.Click += new System.EventHandler(this._syncPanelWidth_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // _leftImagePanBtn
            // 
            this._leftImagePanBtn.CheckOnClick = true;
            this._leftImagePanBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._leftImagePanBtn.Image = ((System.Drawing.Image)(resources.GetObject("_leftImagePanBtn.Image")));
            this._leftImagePanBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._leftImagePanBtn.Name = "_leftImagePanBtn";
            this._leftImagePanBtn.Size = new System.Drawing.Size(34, 28);
            this._leftImagePanBtn.ToolTipText = UIStrings.PanLeftImage;
            // 
            // _rightImagePanBtn
            // 
            this._rightImagePanBtn.CheckOnClick = true;
            this._rightImagePanBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rightImagePanBtn.Image = ((System.Drawing.Image)(resources.GetObject("_rightImagePanBtn.Image")));
            this._rightImagePanBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rightImagePanBtn.Name = "_rightImagePanBtn";
            this._rightImagePanBtn.Size = new System.Drawing.Size(34, 28);
            this._rightImagePanBtn.ToolTipText = UIStrings.PanRightImage;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // _stereoPairSettings
            // 
            this._stereoPairSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._stereoPairSettings.Image = ((System.Drawing.Image)(resources.GetObject("_stereoPairSettings.Image")));
            this._stereoPairSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._stereoPairSettings.Name = "_stereoPairSettings";
            this._stereoPairSettings.Size = new System.Drawing.Size(34, 28);
            this._stereoPairSettings.Click += new System.EventHandler(this._stereoPairSettings_Click);
            // 
            // _imagesSplitContainer
            // 
            this._imagesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imagesSplitContainer.Location = new System.Drawing.Point(0, 33);
            this._imagesSplitContainer.Name = "_imagesSplitContainer";
            // 
            // _imagesSplitContainer.Panel1
            // 
            this._imagesSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this._imagesSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this._imagesSplitContainer_Panel1_Paint);
            this._imagesSplitContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._imagesSplitContainer_Panel1_MouseDown);
            this._imagesSplitContainer.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this._imagesSplitContainer_Panel1_MouseMove);
            // 
            // _imagesSplitContainer.Panel2
            // 
            this._imagesSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this._imagesSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this._imagesSplitContainer_Panel2_Paint);
            this._imagesSplitContainer.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._imagesSplitContainer_Panel2_MouseDown);
            this._imagesSplitContainer.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this._imagesSplitContainer_Panel2_MouseMove);
            this._imagesSplitContainer.Size = new System.Drawing.Size(1316, 724);
            this._imagesSplitContainer.SplitterDistance = 438;
            this._imagesSplitContainer.SplitterWidth = 16;
            this._imagesSplitContainer.TabIndex = 1;
            // 
            // StereoPairViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._imagesSplitContainer);
            this.Controls.Add(this._mainToolStrip);
            this.DoubleBuffered = true;
            this.Name = "StereoPairViewControl";
            this.Size = new System.Drawing.Size(1316, 757);
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imagesSplitContainer)).EndInit();
            this._imagesSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _mainToolStrip;
        private System.Windows.Forms.ToolStripButton _leftImageZoomInBtn;
        private System.Windows.Forms.ToolStripButton _leftImageZoomOutBtn;
        private System.Windows.Forms.ToolStripButton _leftImageResetZoomBtn;
        private System.Windows.Forms.SplitContainer _imagesSplitContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _rightImageZoomInBtn;
        private System.Windows.Forms.ToolStripButton _rightImageZoomOutBtn;
        private System.Windows.Forms.ToolStripButton _rightImageResetZoomBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _syncByLeftImageBtn;
        private System.Windows.Forms.ToolStripButton _syncByRightImageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _stereoPairSettings;
        private System.Windows.Forms.ToolStripButton _syncPanelWidth;
        private System.Windows.Forms.ToolStripButton _leftImagePanBtn;
        private System.Windows.Forms.ToolStripButton _rightImagePanBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
