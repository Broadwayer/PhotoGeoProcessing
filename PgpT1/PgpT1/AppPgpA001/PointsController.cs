using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MM.Photogeo;

namespace AppPgpA001
{
    public class PointsController
    {
        public PresentationStyle PresentationStyle { get; set; }

        List<PointF> _leftImagePoints = new List<PointF>();
        List<PointF> _rightImagePoints = new List<PointF>();

        public void LoadPoints(Uri leftPointsUri, Uri rightPointsUri)
        {

        }

        public void SavePoints(Uri leftPointsUri, Uri rightPointsUri)
        {

        }

        public void LoadPoints(Uri pointsUri, (Uri, Uri) pp)
        {


            JsonPoints2DLoaderSaver jsonPoints2DLoaderSaver = new JsonPoints2DLoaderSaver();
            _leftImagePoints = jsonPoints2DLoaderSaver.LoadPoints2D(pointsUri);
        }

        public void SavePoints(Uri pointsUri)
        {
            JsonPoints2DLoaderSaver jsonPoints2DLoaderSaver = new JsonPoints2DLoaderSaver();
            jsonPoints2DLoaderSaver.SavePoints2D(_leftImagePoints, pointsUri);
        }

        public void AddLeftImagePoint(PointF p)
        {
            //TODO MessageBox
            _leftImagePoints.Add(p);
        }

        public void AddRightImagePoint(PointF p)
        {
            //TODO MessageBox
            _rightImagePoints.Add(p);
        }

        public void DrawLeftImagePoints(Graphics g)
        {
            float wh = 40.0f / g.Transform.Elements[0];
            SizeF symbolSize = new SizeF(wh, wh);
            PointF symbolCenter = new PointF(wh / 2.0f, wh / 2.0f);
            Pen pen = new Pen(Color.Red, 1.0f / g.Transform.Elements[0]);
            Font font = new Font(PresentationStyle.Font.FontFamily,
                PresentationStyle.Font.Size / g.Transform.Elements[0],
                PresentationStyle.Font.Style);

            int pN = 0;
            foreach (PointF p in _leftImagePoints)
                DrawPoint(p, ++pN, g, symbolSize, symbolCenter, font);
        }

        public void DrawRightImagePoints(Graphics g)
        {
            float wh = 40.0f / g.Transform.Elements[0];
            SizeF symbolSize = new SizeF(wh, wh);
            PointF symbolCenter = new PointF(wh / 2.0f, wh / 2.0f);
            Pen pen = new Pen(Color.Red, 1.0f / g.Transform.Elements[0]);
            Font font = new Font(PresentationStyle.Font.FontFamily, 
                PresentationStyle.Font.Size / g.Transform.Elements[0],
                PresentationStyle.Font.Style);

            int pN = 0;
            foreach (PointF p in _rightImagePoints)
                DrawPoint(p, ++pN, g, symbolSize, symbolCenter, font);
        }

        void DrawPoint(PointF p, int index, Graphics g, SizeF symbolSize, PointF symbolCenter, Font font)
        {
            Pen pen = new Pen(PresentationStyle.PointSymbolColor);
            g.DrawEllipse(pen, new RectangleF(p.X - symbolCenter.X, p.Y - symbolCenter.Y, symbolSize.Width, symbolSize.Height));
            g.DrawLine(pen, p.X - symbolCenter.X, p.Y, p.X + symbolCenter.X, p.Y);
            g.DrawLine(pen, p.X, p.Y - symbolCenter.Y, p.X, p.Y + symbolCenter.Y);
            g.DrawString(string.Format("{0} {1}", PresentationStyle.TextPrefix, index),
                font, new SolidBrush(PresentationStyle.TextColor), new PointF(p.X + 2 * symbolCenter.X, p.Y));
        }
    }

    public class PresentationStyle
    {
        public Color PointSymbolColor { get; set; }
        public Font Font { get; set; }
        public Color TextColor { get; set; }
        public string TextPrefix { get; set; }
    }
}
