namespace AppPgpA001
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            _mainMenuStrip = new MenuStrip();
            _fileMenuItem = new ToolStripMenuItem();
            _createStereoPairMenuItem = new ToolStripMenuItem();
            _loadStereoPairMenuItem = new ToolStripMenuItem();
            _mainStatusStrip = new StatusStrip();
            _mainToolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            _mainSplitContainer = new SplitContainer();
            _stereoPairViewControl = new StereoPairViewControl();
            _mainMenuStrip.SuspendLayout();
            _mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_mainSplitContainer).BeginInit();
            _mainSplitContainer.Panel2.SuspendLayout();
            _mainSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            _mainMenuStrip.ImageScalingSize = new Size(24, 24);
            _mainMenuStrip.Items.AddRange(new ToolStripItem[] { _fileMenuItem });
            _mainMenuStrip.Location = new Point(0, 0);
            _mainMenuStrip.Name = "_mainMenuStrip";
            _mainMenuStrip.Size = new Size(1905, 33);
            _mainMenuStrip.TabIndex = 0;
            _mainMenuStrip.Text = "menuStrip1";
            // 
            // _fileMenuItem
            // 
            _fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _createStereoPairMenuItem, _loadStereoPairMenuItem });
            _fileMenuItem.Name = "_fileMenuItem";
            _fileMenuItem.Size = new Size(54, 29);
            _fileMenuItem.Text = "File";
            // 
            // _createStereoPairMenuItem
            // 
            _createStereoPairMenuItem.Name = "_createStereoPairMenuItem";
            _createStereoPairMenuItem.Size = new Size(270, 34);
            _createStereoPairMenuItem.Text = "Create stereo pair";
            _createStereoPairMenuItem.Click += _createStereoPairMenuItem_Click;
            // 
            // _loadStereoPairMenuItem
            // 
            _loadStereoPairMenuItem.Name = "_loadStereoPairMenuItem";
            _loadStereoPairMenuItem.Size = new Size(270, 34);
            _loadStereoPairMenuItem.Text = "Load stereo pair";
            _loadStereoPairMenuItem.Click += _loadStereoPairMenuItem_Click;
            // 
            // _mainStatusStrip
            // 
            _mainStatusStrip.ImageScalingSize = new Size(24, 24);
            _mainStatusStrip.Location = new Point(0, 813);
            _mainStatusStrip.Name = "_mainStatusStrip";
            _mainStatusStrip.Size = new Size(1905, 22);
            _mainStatusStrip.TabIndex = 1;
            _mainStatusStrip.Text = "statusStrip1";
            // 
            // _mainToolStrip
            // 
            _mainToolStrip.ImageScalingSize = new Size(24, 24);
            _mainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            _mainToolStrip.Location = new Point(0, 33);
            _mainToolStrip.Name = "_mainToolStrip";
            _mainToolStrip.Size = new Size(1905, 33);
            _mainToolStrip.TabIndex = 2;
            _mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // _mainSplitContainer
            // 
            _mainSplitContainer.Dock = DockStyle.Fill;
            _mainSplitContainer.Location = new Point(0, 66);
            _mainSplitContainer.Name = "_mainSplitContainer";
            // 
            // _mainSplitContainer.Panel2
            // 
            _mainSplitContainer.Panel2.Controls.Add(_stereoPairViewControl);
            _mainSplitContainer.Size = new Size(1905, 747);
            _mainSplitContainer.SplitterDistance = 412;
            _mainSplitContainer.TabIndex = 3;
            // 
            // _stereoPairViewControl
            // 
            _stereoPairViewControl.Dock = DockStyle.Fill;
            _stereoPairViewControl.FileNameImageLeft = null;
            _stereoPairViewControl.FileNameImageRight = null;
            _stereoPairViewControl.Location = new Point(0, 0);
            _stereoPairViewControl.Margin = new Padding(3, 4, 3, 4);
            _stereoPairViewControl.Name = "_stereoPairViewControl";
            _stereoPairViewControl.PointsController = null;
            _stereoPairViewControl.Size = new Size(1489, 747);
            _stereoPairViewControl.TabIndex = 0;
            _stereoPairViewControl.WorkSpace = null;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1905, 835);
            Controls.Add(_mainSplitContainer);
            Controls.Add(_mainToolStrip);
            Controls.Add(_mainStatusStrip);
            Controls.Add(_mainMenuStrip);
            MainMenuStrip = _mainMenuStrip;
            Name = "FormMain";
            Text = "Stereo pair processor";
            _mainMenuStrip.ResumeLayout(false);
            _mainMenuStrip.PerformLayout();
            _mainToolStrip.ResumeLayout(false);
            _mainToolStrip.PerformLayout();
            _mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_mainSplitContainer).EndInit();
            _mainSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip _mainMenuStrip;
        private StatusStrip _mainStatusStrip;
        private ToolStripMenuItem _fileMenuItem;
        private ToolStripMenuItem _createStereoPairMenuItem;
        private ToolStripMenuItem _loadStereoPairMenuItem;
        private ToolStrip _mainToolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private SplitContainer _mainSplitContainer;
        private StereoPairViewControl _stereoPairViewControl;
    }
}
