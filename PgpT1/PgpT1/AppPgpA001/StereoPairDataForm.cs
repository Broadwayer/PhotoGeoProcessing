using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MM.Photogeo;

namespace AppPgpA001
{
    public partial class StereoPairDataForm : Form
    {
        StereoPairView _dataSource;
        StereoPairView _backUpDataSource;

        public StereoPairDataForm()
        {
            InitializeComponent();
            this._okButton.Enabled = DataSourceValidation();
        }

        public StereoPairView DataSource
        { 
            get => _dataSource;
            set
            {
                _dataSource = value;
                _backUpDataSource = (StereoPairView)value.Clone();
                UpdateDataBindings();

                _dataSource.PropertyChanged += _dataSource_PropertyChanged;
                this._okButton.Enabled = DataSourceValidation();
            }
        }

        bool DataSourceValidation()
        {
            if (_dataSource == null)
                return false;
            else if(string.IsNullOrEmpty(_dataSource.Name) || 
                string.IsNullOrEmpty(_dataSource.WorkSpace) ||
                string.IsNullOrEmpty(_dataSource.FileNameImageLeft) ||
                string.IsNullOrEmpty(_dataSource.FileNameImageRight) ||
                _dataSource.Basis <= 0.0f ||
                _dataSource.FX <= 0.0f || _dataSource.FY <= 0.0f ||
                _dataSource.CX <= 0.0f || _dataSource.CY <= 0.0f)
                return false;
            else
                return true;
        }

        private void _dataSource_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            this._okButton.Enabled = DataSourceValidation();
        }

        void UpdateDataBindings()
        {
            this._stereoPairLocationTextBox.DataBindings.Clear();
            this._stereoPairIDTextBox.DataBindings.Clear();
            this._focalLengthXTextBox.DataBindings.Clear();
            this._focalLengthYTextBox.DataBindings.Clear();
            this._principalXTextBox.DataBindings.Clear();
            this._principalYTextBox.DataBindings.Clear();

            if (_dataSource == null)
                return;

            this._stereoPairLocationTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.WorkSpace));
            this._stereoPairIDTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.Name));
            this._basisTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.Basis));
            this._focalLengthXTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.FX));
            this._focalLengthYTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.FY));
            this._principalXTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.CX));
            this._principalYTextBox.DataBindings.Add("Text", _dataSource, nameof(StereoPairView.CY));
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(_dataSource.WorkSpace, _dataSource.Name + ".sp");

            IStreoPairLoaderSaver ls = new JsonStereoPairLoaderSaver();
            ls.SaveStereoPair(_dataSource, new Uri(path));
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            _dataSource.Name = _backUpDataSource.Name;
            _dataSource.WorkSpace = _backUpDataSource.WorkSpace;
            _dataSource.Basis = _backUpDataSource.Basis;
            _dataSource.FX = _backUpDataSource.FX;
            _dataSource.FY = _backUpDataSource.FY;
            _dataSource.CX = _backUpDataSource.CX;
            _dataSource.CY = _backUpDataSource.CY;
        }

        private void _resetButton_Click(object sender, EventArgs e)
        {

        }

        class ImgComboBoxItem
        {
            public FileInfo FileInfo { get; private set; }

            public ImgComboBoxItem(FileInfo fileInfo)
            { 
                this.FileInfo = fileInfo; 
            }

            public override string ToString()
            {
                return FileInfo.Name;
            }
        }


        private void _stereoPairLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() != DialogResult.OK)
                return;

            _dataSource.WorkSpace = fbd.SelectedPath;

            System.IO.DirectoryInfo imagesDir = new System.IO.DirectoryInfo(fbd.SelectedPath + "\\Images");

            System.IO.FileInfo[] imgFiles = imagesDir.GetFiles()
                .Where(f => f.Extension.ToUpper() == ".JPG" || f.Extension.ToUpper() == ".PNG")
                .ToArray();

            _leftImageComboBox.SelectedIndexChanged -= _leftImageComboBox_SelectedIndexChanged;
            _leftImageComboBox.Items.Clear();
            _leftImageComboBox.Items.Add("...");
            //_leftImageComboBox.Items.AddRange(imgFiles);
            foreach(var f in imgFiles)
                _leftImageComboBox.Items.Add(new ImgComboBoxItem(f));
            _leftImageComboBox.SelectedIndex = 0;
            _leftImageComboBox.SelectedIndexChanged += _leftImageComboBox_SelectedIndexChanged;

            _rightImageComboBox.SelectedIndexChanged -= _rightImageComboBox_SelectedIndexChanged;
            _rightImageComboBox.Items.Clear();
            _rightImageComboBox.Items.Add("...");
            //_rightImageComboBox.Items.AddRange(imgFiles);
            foreach (var f in imgFiles)
                _rightImageComboBox.Items.Add(new ImgComboBoxItem(f));
            _rightImageComboBox.SelectedIndex = 0;
            _rightImageComboBox.SelectedIndexChanged += _rightImageComboBox_SelectedIndexChanged;
        }

        private void _rightImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataSource.FileNameImageRight = (_rightImageComboBox.SelectedItem as ImgComboBoxItem).FileInfo.Name;
        }

        private void _leftImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataSource.FileNameImageLeft = (_leftImageComboBox.SelectedItem as ImgComboBoxItem).FileInfo.Name;
        }

        void UpdateImageComboBoxes()
        {

        }
    }
}
