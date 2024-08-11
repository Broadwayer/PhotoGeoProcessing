using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPgpA
{
    public partial class FormMain : Form
    {
        string _pathToImgL;
        string _pathToImgR;
        string _pathTo2dPointsL;
        string _pathTo2dPointsR;
        string _pathTo3dPoints = "AAA";
        float _basis = 1.0f;

        PgpController _controller;

        public FormMain()
        {
            InitializeComponent();
            _basisTextBox.Text = _basis.ToString();


            _controller = new PgpController();
        }

        Point _panel1MousePrev;
        Point _panel2MousePrev;
        Point _bmpLeftPos;
        Point _bmpRightPos;
        float _bmpLeftScaleFactor = 1.0f;
        float _bmpRightScaleFactor = 1.0f;
        Bitmap _bmpLeft;
        Bitmap _bmpRight;
        List<PointF> _bmpLeftSelectedPoints = new List<PointF>();
        List<PointF> _bmpRightSelectedPoints = new List<PointF>();
        float _kXLeft = 0.0f;
        float _kYLeft = 0.0f;
        float _kXRight = 0.0f;
        float _kYRight = 0.0f;

        private void _loadLeftImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = UIStrings.LoadLeftImage;
            ofd.Filter = string.Format("{0} (*.png)|*.png|{1} (*.jpg)|*.jpg|{2} (*.*)|*.*", "PNG-Files", "JPG-Files", "All Files");
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            
            _pathToImgL = ofd.FileName;
            _bmpLeftSelectedPoints.Clear();
            _bmpLeft = new Bitmap(_pathToImgL);
            _bmpLeftPos = new Point(0, 0);
            _kXLeft = Graphics.FromHwnd(_splitContainerImages.Panel1.Handle).DpiX / _bmpLeft.HorizontalResolution;
            _kYLeft = Graphics.FromHwnd(_splitContainerImages.Panel1.Handle).DpiY / _bmpLeft.VerticalResolution;
            _splitContainerImages.Panel1.Refresh();
        }

        private void _loadRightImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = UIStrings.LoadRightImage;
            ofd.Filter = string.Format("{0} (*.png)|*.png|{1} (*.jpg)|*.jpg|{2} (*.*)|*.*", "PNG-Files", "JPG-Files", "All Files");
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            _pathToImgR = ofd.FileName;
            _bmpRightSelectedPoints.Clear();
            _bmpRight = new Bitmap(_pathToImgR);
            _bmpRightPos = new Point(0, 0);
            _kXRight = Graphics.FromHwnd(_splitContainerImages.Panel2.Handle).DpiX / _bmpRight.HorizontalResolution;
            _kYRight = Graphics.FromHwnd(_splitContainerImages.Panel2.Handle).DpiY / _bmpRight.VerticalResolution;
            _splitContainerImages.Panel2.Refresh();
        }

        private void _leftImageZoomInBtn_Click(object sender, EventArgs e)
        {
            if (_bmpLeftScaleFactor == 5.0f)
                return;
            _bmpLeftScaleFactor += 0.05f;
            _bmpLeftScaleFactor = (float)Math.Round(_bmpLeftScaleFactor, 2);
            _splitContainerImages.Panel1.Invalidate();
        }

        private void _leftImageZoomOutBtn_Click(object sender, EventArgs e)
        {
            if (_bmpLeftScaleFactor == 0.05f)
                return;
            _bmpLeftScaleFactor -= 0.05f;
            _bmpLeftScaleFactor = (float)Math.Round(_bmpLeftScaleFactor, 2);
            _splitContainerImages.Panel1.Invalidate();
        }

        private void _leftImageResetZoomBtn_Click(object sender, EventArgs e)
        {
            _bmpLeftScaleFactor = 1.0f;
            _splitContainerImages.Panel1.Invalidate();
        }

        private void _rightImageZoomInBtn_Click(object sender, EventArgs e)
        {
            if (_bmpRightScaleFactor == 5.0f)
                return;
            _bmpRightScaleFactor += 0.05f;
            _bmpRightScaleFactor = (float)Math.Round(_bmpRightScaleFactor, 2);
            _splitContainerImages.Panel2.Invalidate();
        }

        private void _rightImageZoomOutBtn_Click(object sender, EventArgs e)
        {
            if (_bmpRightScaleFactor == 0.05f)
                return;
            _bmpRightScaleFactor -= 0.05f;
            _bmpRightScaleFactor = (float)Math.Round(_bmpRightScaleFactor, 2);
            _splitContainerImages.Panel2.Invalidate();
        }

        private void _rightImageResetZoomBtn_Click(object sender, EventArgs e)
        {
            _bmpRightScaleFactor = 1.0f;
            _splitContainerImages.Panel2.Invalidate();
        }

        private void _syncByLeftImageBtn_Click(object sender, EventArgs e)
        {
            _bmpRightScaleFactor = _bmpLeftScaleFactor;
            _bmpRightPos.X = _bmpLeftPos.X;
            _bmpRightPos.Y = _bmpLeftPos.Y;
            _splitContainerImages.Panel2.Invalidate();
        }

        private void _syncByRightImageBtn_Click(object sender, EventArgs e)
        {
            _bmpLeftScaleFactor = _bmpRightScaleFactor;
            _bmpLeftPos.X = _bmpRightPos.X;
            _bmpLeftPos.Y = _bmpRightPos.Y;
            _splitContainerImages.Panel1.Invalidate();
        }

        private void _bmpLeftPointsLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pathTo2dPointsL = ofd.FileName;
                _bmpLeftSelectedPoints.Clear();
                _bmpLeftSelectedPoints.AddRange(LoadPoints(_pathTo2dPointsL, _bmpLeft.Height, _kXLeft, _kYLeft));
            }
        }

        private void _bmpLeftPointsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _pathTo2dPointsL = sfd.FileName;
                _bmpLeftSelectedPoints.Clear();
                _bmpLeftSelectedPoints.AddRange(LoadPoints(_pathTo2dPointsL, _bmpLeft.Height, _kXLeft, _kYLeft));
            }
        }

        private void _bmpRightPointsLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pathTo2dPointsR = ofd.FileName;
                _bmpRightSelectedPoints.Clear();
                _bmpRightSelectedPoints.AddRange(LoadPoints(_pathTo2dPointsR, _bmpRight.Height, _kXRight, _kYRight));
            }
        }

        private void _bmpRightPointsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _pathTo2dPointsR = sfd.FileName;
                _bmpRightSelectedPoints.Clear();
                SavePoints(_bmpRightSelectedPoints, _pathTo2dPointsR, _kXRight, _kYRight);
            }
        }

        void SavePoints(IEnumerable<PointF> points, string path, float kX, float kY)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (PointF p in points)
                {
                    sw.WriteLine(string.Format("{0},{1}",
                        (p.X / kX).ToString("0.0").Replace(",", "."),
                        (p.Y / kY).ToString("0.0").Replace(",", ".")));
                }
                sw.Flush();
                sw.Close();
            }
        }

        IEnumerable<PointF> LoadPoints(string path, float imgH, float kX, float kY)
        {
            List<PointF> points = new List<PointF>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] xy = sr.ReadLine().Split(",".ToCharArray());
                    PointF p = new PointF(float.Parse(xy[0], CultureInfo.InvariantCulture),
                        float.Parse(xy[1], CultureInfo.InvariantCulture));
                    p.X = p.X * kX;
                    p.Y = p.Y * kY;
                    points.Add(p);
                }
            }
            return points;
        }

        void DrawSelectedPoint(PointF p, Graphics g, string txt)
        {
            float wh = 40.0f / g.Transform.Elements[0];
            float hwh = wh / 2.0f;
            Pen pen = new Pen(Color.Red, 1.0f / g.Transform.Elements[0]);
            g.DrawEllipse(pen, new RectangleF(p.X - hwh, p.Y - hwh, wh, wh));
            g.DrawLine(pen, p.X - hwh, p.Y, p.X + hwh, p.Y);
            g.DrawLine(pen, p.X, p.Y - hwh, p.X, p.Y + hwh);
            Font f = new Font("Arial", 12.0f / g.Transform.Elements[0]);
            g.DrawString(txt, f, Brushes.Red, p.X + hwh, p.Y);
        }

        PointF GetRealPos(int iX, int iY, Point imgPos, float scaleFactor)
        {
            return new PointF((iX - imgPos.X) / scaleFactor, (iY - imgPos.Y) / scaleFactor);
        }

        private void _splitContainerImages_Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(_bmpLeftPos.X, _bmpLeftPos.Y);
            e.Graphics.ScaleTransform(_bmpLeftScaleFactor, _bmpLeftScaleFactor);
            if (_bmpLeft != null)
            {
                
                e.Graphics.DrawImage(_bmpLeft, new Point(0, 0));
                int idx = 0;
                if (_displayLeftImagePoints.Checked)
                    foreach (var point in _bmpLeftSelectedPoints)
                        DrawSelectedPoint(point, e.Graphics, string.Format("L-{0}", ++idx));
            }
        }

        private void _splitContainerImages_Panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(_bmpRightPos.X, _bmpRightPos.Y);
            e.Graphics.ScaleTransform(_bmpRightScaleFactor, _bmpRightScaleFactor);
            if (_bmpRight != null)
            {
                e.Graphics.DrawImage(_bmpRight, new Point(0, 0));
                int idx = 0;
                if (_displayRightImagePoints.Checked)
                    foreach (var point in _bmpRightSelectedPoints)
                        DrawSelectedPoint(point, e.Graphics, string.Format("R-{0}", ++idx));
            }
        }

        private void _splitContainerImages_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _leftImageMoveBtn.Checked)
            {
                _bmpLeftPos.X += (e.X - _panel1MousePrev.X);
                _bmpLeftPos.Y += (e.Y - _panel1MousePrev.Y);

                _splitContainerImages.Panel1.Invalidate();
                _panel1MousePrev = new Point(e.X, e.Y);
            }
        }

        private void _splitContainerImages_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _leftImageMoveBtn.Checked)
                _panel1MousePrev = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left && _bmpLeft != null)
            {
                PointF p = GetRealPos(e.X, e.Y, _bmpLeftPos, _bmpLeftScaleFactor);
                if (MessageBox.Show(p.ToString() + "\nAdd this point to list?", "Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _bmpLeftSelectedPoints.Add(p);
                    _splitContainerImages.Panel1.Refresh();
                }
            }
        }

        private void _splitContainerImages_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _rightImageMoveBtn.Checked)
            {
                _bmpRightPos.X += (e.X - _panel2MousePrev.X);
                _bmpRightPos.Y += (e.Y - _panel2MousePrev.Y);

                _splitContainerImages.Panel2.Invalidate();
                _panel2MousePrev = new Point(e.X, e.Y);
            }
        }

        private void _splitContainerImages_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _rightImageMoveBtn.Checked)
                _panel2MousePrev = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left && _bmpRight != null)
            {
                PointF p = GetRealPos(e.X, e.Y, _bmpRightPos, _bmpRightScaleFactor);
                if (MessageBox.Show(p.ToString() + "\nAdd this point to list?", "Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _bmpRightSelectedPoints.Add(p);
                    _splitContainerImages.Panel2.Refresh();
                }
            }
        }

        private void _displayLeftImagePoints_CheckStateChanged(object sender, EventArgs e)
        {
            _splitContainerImages.Panel1.Refresh();
        }

        private void _displayRightImagePoints_CheckStateChanged(object sender, EventArgs e)
        {
            _splitContainerImages.Panel2.Refresh();
        }

        private void _procStereoPairBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = string.Format("{0} (*.py)|*.py|{1} (*.*)|*.*", "Python-Files", "All Files");
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            if (!File.Exists(ofd.FileName))
                return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = string.Format("{0} (*.txt)|*.txt|{1} (*.*)|*.*", "Text-Files", "All Files");
            sfd.Title = "3D - Points";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _pathTo3dPoints = sfd.FileName;
            }

            Process p = new Process();
            p.StartInfo.FileName = "python";
            p.EnableRaisingEvents = true;
            p.StartInfo.Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", 
                ofd.FileName, 
                _pathToImgL, _pathToImgR, 
                _pathTo2dPointsL, _pathTo2dPointsR,
                _pathTo3dPoints, _basis);

            p.Exited += P_Exited;
            p.Start();
        }

        private void P_Exited(object sender, EventArgs e)
        {
            
        }

        private void _basisTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Debug.WriteLine("KEY DOWN");
            if(e.KeyCode == Keys.Enter)
            {
                if (!float.TryParse(_basisTextBox.Text, out _basis))
                    _basisTextBox.Text = "1";
            }
                
            
        }

        private void _basisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Debug.WriteLine("KEY PRESS");
        }

        private void _basisTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Debug.WriteLine("KEY UP");
        }

        private void _createNewStereoPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.CreateStereoPair();
        }

        private void _loadStereoPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_controller.LoadStereoPair()
        }

        private void _stereoPairSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.StereoPairSettings();
        }
    }
}
