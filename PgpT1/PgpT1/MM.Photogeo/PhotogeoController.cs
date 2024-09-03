using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Photogeo
{
    public struct Point3D
    {
        public Point3D()
        { }

        public Point3D(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }   
    }

    public interface IPhotogeoController
    {
        (List<PointF>, List<PointF>) FindKeyPoints(IStereoPair stereoPair);
        List<Point3D> ProcStereoPair((List<PointF>, List<PointF>) points, (List<PointF>, List<PointF>) keyPoints, IStereoPair stereoPair);
    }
}
