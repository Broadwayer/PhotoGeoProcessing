using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MM.Photogeo;

namespace AppPgpA001
{
    public partial class StereoPairViewControl : UserControl
    {
        StereoPairView _dataSource;
        Bitmap _bmpLeft;
        Bitmap _bmpRight;
        Point _bmpLeftPos;
        Point _bmpRightPos;
        float _bmpLeftScaleFactor = 1;
        float _bmpRightScaleFactor = 1;

        string _workSpace;
        string _fileNameImageLeft;
        string _fileNameImageRight;

        float _scaleFactorMax = 5.0f;
        float _scaleFactorMin = 0.05f;
        float _scaleFactorStep = 0.05f;

        Point _panel1MousePrev;
        Point _panel2MousePrev;

        PointsController _pointsController;

        public PointsController PointsController
        {
            get { return _pointsController; }
            set { _pointsController = value; }
        }

        public string WorkSpace
        {
            get => _workSpace;
            set
            {
                _workSpace = value;
                UpdateBitmapLeft();
                UpdateBitmapRight();
            }
        }

        public string FileNameImageLeft
        {
            get => _fileNameImageLeft;
            set
            {
                _fileNameImageLeft = value;
                UpdateBitmapLeft();
            }
        }

        public string FileNameImageRight
        {
            get => _fileNameImageRight;
            set
            {
                _fileNameImageRight = value;
                UpdateBitmapRight();
            }
        }

        void UpdateBitmapLeft()
        {
            if ((string.IsNullOrEmpty(_workSpace) || string.IsNullOrEmpty(_fileNameImageLeft)) ||
                !File.Exists(Path.Combine(_workSpace + "\\Images", _fileNameImageLeft)))
            {
                _bmpLeft = null;
                return;
            }

            _bmpLeft = new Bitmap(Path.Combine(_workSpace + "\\Images", _fileNameImageLeft));
            _imagesSplitContainer.Panel1.Invalidate();
        }

        void UpdateBitmapRight()
        {
            if ((string.IsNullOrEmpty(_workSpace) || string.IsNullOrEmpty(_fileNameImageRight)) ||
                !File.Exists(Path.Combine(_workSpace + "\\Images", _fileNameImageRight)))
            {
                _bmpRight = null;
                return;
            }

            _bmpRight = new Bitmap(Path.Combine(_workSpace + "\\Images", _fileNameImageRight));
            _imagesSplitContainer.Panel2.Invalidate();
        }

        public StereoPairView DataSource
        {
            get { return _dataSource; }
            set
            {
                this.DataBindings.Clear();
                _bmpLeftScaleFactor = 1;
                _bmpRightScaleFactor = 1;
                _dataSource = value;
                if (value == null)
                    return;
                this.DataBindings.Add(nameof(WorkSpace), _dataSource, nameof(StereoPairView.WorkSpace));
                this.DataBindings.Add(nameof(FileNameImageLeft), _dataSource, nameof(StereoPairView.FileNameImageLeft));
                this.DataBindings.Add(nameof(FileNameImageRight), _dataSource, nameof(StereoPairView.FileNameImageRight));
            }
        }


        public StereoPairViewControl()
        {
            InitializeComponent();
        }

        private void _leftImageZoomInBtn_Click(object sender, EventArgs e)
        {
            if (_bmpLeftScaleFactor == _scaleFactorMax)
                return;
            _bmpLeftScaleFactor += _scaleFactorStep;
            _bmpLeftScaleFactor = (float)Math.Round(_bmpLeftScaleFactor, 2);
            _imagesSplitContainer.Panel1.Invalidate();
        }

        private void _leftImageZoomOutBtn_Click(object sender, EventArgs e)
        {
            if (_bmpLeftScaleFactor == _scaleFactorMin)
                return;
            _bmpLeftScaleFactor -= _scaleFactorStep;
            _bmpLeftScaleFactor = (float)Math.Round(_bmpLeftScaleFactor, 2);
            _imagesSplitContainer.Panel1.Invalidate();
        }

        private void _leftImageResetZoomBtn_Click(object sender, EventArgs e)
        {
            _bmpLeftScaleFactor = 1;
            _imagesSplitContainer.Panel1.Invalidate();
        }

        private void _rightImageZoomInBtn_Click(object sender, EventArgs e)
        {
            if (_bmpRightScaleFactor == _scaleFactorMax)
                return;
            _bmpRightScaleFactor += _scaleFactorStep;
            _bmpRightScaleFactor = (float)Math.Round(_bmpRightScaleFactor, 2);
            _imagesSplitContainer.Panel2.Invalidate();
        }

        private void _rightImageZoomOutBtn_Click(object sender, EventArgs e)
        {
            if (_bmpRightScaleFactor == _scaleFactorMin)
                return;
            _bmpRightScaleFactor -= _scaleFactorStep;
            _bmpRightScaleFactor = (float)Math.Round(_bmpRightScaleFactor, 2);
            _imagesSplitContainer.Panel2.Invalidate();
        }

        private void _rightImageResetZoomBtn_Click(object sender, EventArgs e)
        {
            _bmpRightScaleFactor = 1;
            _imagesSplitContainer.Panel2.Invalidate();
        }

        private void _syncByLeftImageBtn_Click(object sender, EventArgs e)
        {
            _bmpRightScaleFactor = _bmpLeftScaleFactor;
            _bmpRightPos.X = _bmpLeftPos.X;
            _bmpRightPos.Y = _bmpLeftPos.Y;
            _imagesSplitContainer.Panel2.Invalidate();
        }

        private void _syncByRightImageBtn_Click(object sender, EventArgs e)
        {
            _bmpLeftScaleFactor = _bmpRightScaleFactor;
            _bmpLeftPos.X = _bmpRightPos.X;
            _bmpLeftPos.Y = _bmpRightPos.Y;
            _imagesSplitContainer.Panel1.Invalidate();
        }

        private void _syncPanelWidth_Click(object sender, EventArgs e)
        {
            _imagesSplitContainer.SplitterDistance = (_imagesSplitContainer.Width - _imagesSplitContainer.SplitterWidth) / 2;
        }

        private void _stereoPairSettings_Click(object sender, EventArgs e)
        {

        }

        private void _imagesSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(_bmpLeftPos.X, _bmpLeftPos.Y);
            e.Graphics.ScaleTransform(_bmpLeftScaleFactor, _bmpLeftScaleFactor);
            if (_bmpLeft != null)
                e.Graphics.DrawImage(_bmpLeft, new Point(0, 0));
            if (_pointsController != null)
                _pointsController.DrawLeftImagePoints(e.Graphics);
        }

        private void _imagesSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(_bmpRightPos.X, _bmpRightPos.Y);
            e.Graphics.ScaleTransform(_bmpRightScaleFactor, _bmpRightScaleFactor);
            if (_bmpRight != null)
                e.Graphics.DrawImage(_bmpRight, new Point(0, 0));
            if (_pointsController != null)
                _pointsController.DrawRightImagePoints(e.Graphics);
        }

        private void _imagesSplitContainer_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _leftImagePanBtn.Checked)
                _panel1MousePrev = new Point(e.X, e.Y);
            else if (e.Button == MouseButtons.Left)
            {
                if (_pointsController != null)
                {
                    PointF p = getRealPos(e.X, e.Y, _bmpLeftPos, _bmpLeftScaleFactor);
                    _pointsController.AddLeftImagePoint(p);
                    _imagesSplitContainer.Panel1.Invalidate();
                }
            }
        }

        private void _imagesSplitContainer_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _leftImagePanBtn.Checked)
            {
                _bmpLeftPos.X += (e.X - _panel1MousePrev.X);
                _bmpLeftPos.Y += (e.Y - _panel1MousePrev.Y);

                _imagesSplitContainer.Panel1.Invalidate();
                _panel1MousePrev = new Point(e.X, e.Y);
            }
        }

        private void _imagesSplitContainer_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _rightImagePanBtn.Checked)
                _panel2MousePrev = new Point(e.X, e.Y);
            else if (e.Button == MouseButtons.Left)
            {
                if (_pointsController != null)
                {
                    PointF p = getRealPos(e.X, e.Y, _bmpRightPos, _bmpRightScaleFactor);
                    _pointsController.AddRightImagePoint(p);
                    _imagesSplitContainer.Panel2.Invalidate();
                }
            }
        }

        private void _imagesSplitContainer_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _rightImagePanBtn.Checked)
            {
                _bmpRightPos.X += (e.X - _panel2MousePrev.X);
                _bmpRightPos.Y += (e.Y - _panel2MousePrev.Y);

                _imagesSplitContainer.Panel2.Invalidate();
                _panel2MousePrev = new Point(e.X, e.Y);
            }
        }

        PointF getRealPos(int iX, int iY, Point imgPos, float scaleFactor)
        {
            return new PointF((iX - imgPos.X) / scaleFactor, (iY - imgPos.Y) / scaleFactor);
        }
    }
}
