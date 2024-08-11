using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPgpA
{
    #region CONTROLLER_1
#if CONTROLLER_1
    public class PgpController : INotifyPropertyChanged
    {
        string _pathToImgL;
        string _pathToImgR;
        string _pathTo2dPointsL;
        string _pathTo2dPointsR;
        string _pathTo3dPoints;
        float _basis;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string PathToImageLeft
        { 
            get { return _pathToImgL; } 
            set 
            { 
                _pathToImgL = value;
                OnPropertyChanged(nameof(PathToImageLeft));
            } 
        }

        public string PathToImageRight
        { 
            get { return _pathToImgR; } 
            set 
            { 
                _pathToImgR = value;
                OnPropertyChanged(nameof(PathToImageRight));
            } 
        }

        public string PathTo2dPointsLeft
        {  
            get { return _pathTo2dPointsL;} 
            set 
            { 
                _pathTo2dPointsL = value;
                OnPropertyChanged(nameof(PathTo2dPointsLeft));
            } 
        }

        public string PathTo2dPointsRight
        {  
            get { return _pathTo2dPointsR;} 
            set 
            { 
                _pathTo2dPointsR = value;
                OnPropertyChanged(nameof(PathTo2dPointsRight));
            } 
        }

        public string PathTo3dPoints
        {  
            get { return _pathTo3dPoints; } 
            set 
            { 
                _pathTo3dPoints = value;
                OnPropertyChanged(nameof(PathTo3dPoints));
            } 
        }

        public float Basis
        { 
            get { return _basis; } 
            set 
            { 
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            } 
        }

        public void ProcStereoPair()
        {
            
        }
    }
#endif
#endregion


    public class PgpController
    {
        StereoPair _stereoPair;

        public void LoadStereoPair(string path)
        { 
            _stereoPair = StereoPair.Load(path);
        }

        public void SaveStereoPair(string path) 
        { }

        public void CreateStereoPair()
        { 
            _stereoPair = new StereoPair();
            //Call StereoPairDataForm
        }

        public void StereoPairSettings()
        {
            //Call StereoPairDataForm
        }
    }


    public class StereoPair
    {

        public struct Point3D
        {
            public float X { get; set; }

            public float Y { get; set; }

            public float Z { get; set; }
        }

        public static StereoPair Load(string filename)
        {
            return null;
        }

        public static void Save(string filename, StereoPair stereoPair)
        {

        }

        string _name;
        string _description;

        string _fileNameImageLeft;
        string _fileNameImageRight;

        float _basis;
        float _fX;
        float _fY;
        float _cX;
        float _cY;

        List<PointF> _keyPointsLeft;
        List<PointF> _keyPointsRight;

        public float Basis
        { get { return _basis; } set { _basis = value; } }
        public float FocalLengthX { get { return _fX; } set { _fX = value;} }
        public float FocalLengthY { get { return _fY; } set { _fY = value;} }
        public float PrincipalX { get { return _cX; } set { _cX = value;} }
        public float PrincipalY { get { return _cY; } set { _cY = value;} }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public string FileNameImageLeft
        { get { return _fileNameImageLeft;} set { _fileNameImageLeft = value;} }
        public string FileNameImageRight
        { get { return _fileNameImageRight;} set { _fileNameImageRight = value;} }

        public List<PointF> KeyPointsLeft
        { get { return _keyPointsLeft; } set { _keyPointsLeft = value; } }
        public List<PointF> KeyPointsRight
        { get { return _keyPointsRight; } set { _keyPointsRight = value; } }
    }


}
