using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MM.Photogeo
{
    public class JsonStereoPairLoaderSaver : IStreoPairLoaderSaver
    {
        class IternalStereoPair : IStereoPair
        {
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string FileNameImageLeft { get; set; } = string.Empty;
            public string FileNameImageRight { get; set; } = string.Empty;
            public float Basis { get; set; }
            public float FX { get; set; }
            public float FY { get; set; }
            public float CX { get; set; }
            public float CY { get; set; }
        }

        public IStereoPair LoadStereoPair(Uri uri)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.IO.File.ReadAllText(uri.AbsolutePath);
            IternalStereoPair stereoPair = JsonSerializer.Deserialize<IternalStereoPair>(jsonString, options)!;

            return stereoPair;
        }

        public void SaveStereoPair(IStereoPair stereoPair, Uri uri)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(stereoPair, typeof(IStereoPair), options);
            System.IO.File.WriteAllText(uri.AbsolutePath, jsonString);
        }
    }

    public class JsonPoints2DLoaderSaver : IPoints2DLoaderSaver
    {
        struct InternalPoint2D
        {
            public float X { get; set; }
            public float Y { get; set; }

            public InternalPoint2D() { }
            public InternalPoint2D(float x, float y) { X = x; Y = y; }
        }

        public List<PointF> LoadPoints2D(Uri uri)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.IO.File.ReadAllText(uri.AbsolutePath);
            List<InternalPoint2D> points = JsonSerializer.Deserialize<List<InternalPoint2D>>(jsonString, options)!;

            return points.ConvertAll<PointF>(delegate (InternalPoint2D p) { return new PointF(p.X, p.Y); });
        }

        public void SavePoints2D(List<PointF> points, Uri uri)
        {
            List<InternalPoint2D> internalPoints = points.ConvertAll<InternalPoint2D>(delegate (PointF p) { return new InternalPoint2D(p.X, p.Y); });

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(internalPoints, typeof(List<InternalPoint2D>), options);
            System.IO.File.WriteAllText(uri.AbsolutePath, jsonString);
        }
    }
}
