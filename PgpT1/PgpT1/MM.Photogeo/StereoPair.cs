using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MM.Photogeo
{
    public interface IStereoPair
    {
        string Name { get; set; }
        string Description { get; set; }
        string FileNameImageLeft { get; set; }
        string FileNameImageRight { get; set; }
        float Basis { get; set; }
        float FX { get; set; }
        float FY { get; set; }
        float CX { get; set; }
        float CY { get; set; }
    }

    public interface IStreoPairLoaderSaver
    {
        IStereoPair LoadStereoPair(Uri uri);
        void SaveStereoPair(IStereoPair stereoPair, Uri uri);
    }

    public interface IPoints2DLoaderSaver
    {
        void SavePoints2D(List<PointF> points, Uri uri);
        List<PointF> LoadPoints2D(Uri uri);
    }

    public class StereoPairView : IStereoPair, INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        string _workSpace;
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

        public string WorkSpace
        {
            get => _workSpace;
            set
            {
                _workSpace = value;
                OnPropertyChanged(nameof(WorkSpace));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string FileNameImageLeft
        {
            get => _fileNameImageLeft;
            set
            {
                _fileNameImageLeft = value;
                OnPropertyChanged(nameof(FileNameImageLeft));
            }
        }

        public string FileNameImageRight
        {
            get => _fileNameImageRight;
            set
            {
                _fileNameImageRight = value;
                OnPropertyChanged(nameof(FileNameImageRight));
            }
        }

        public float Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }

        public float FX
        {
            get => _fX;
            set
            {
                _fX = value;
                OnPropertyChanged(nameof(FX));
            }
        }

        public float FY
        {
            get => _fY;
            set
            {
                _fY = value;
                OnPropertyChanged(nameof(FY));
            }
        }

        public float CX
        {
            get => _cX;
            set
            {
                _cX = value;
                OnPropertyChanged(nameof(CX));
            }
        }

        public float CY
        {
            get => _cY;
            set
            {
                _cY = value;
                OnPropertyChanged(nameof(CY));
            }
        }
    }
}
