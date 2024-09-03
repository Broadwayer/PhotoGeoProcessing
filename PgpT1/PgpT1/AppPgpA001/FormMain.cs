using MM.Photogeo;

namespace AppPgpA001
{
    public partial class FormMain : Form
    {
        PointsController _keyPointsController = new PointsController() 
        { 
            PresentationStyle = new PresentationStyle() 
            { 
                Font = new Font("Arial", 12.0f),
                TextColor = Color.LightGreen,
                TextPrefix = "K",
                PointSymbolColor = Color.LightGreen
            } 
        };
        PointsController _pointsController = new PointsController()
        {
            PresentationStyle = new PresentationStyle()
            {
                Font = new Font("Arial", 12.0f),
                TextColor = Color.LightGreen,
                TextPrefix = "P",
                PointSymbolColor = Color.LightGreen
            }
        };

        public FormMain()
        {
            InitializeComponent();

            _stereoPairViewControl.PointsController = _pointsController;
        }

        private void _createStereoPairMenuItem_Click(object sender, EventArgs e)
        {
            StereoPairDataForm spDF = new StereoPairDataForm();
            spDF.Text = UIStrings.CreateStereoPair;
            StereoPairView stereoPairView = new StereoPairView();
            spDF.DataSource = stereoPairView;

            if (spDF.ShowDialog() != DialogResult.OK)
                return;

            //TODO Save stereo pair
            //TODO

            _stereoPairViewControl.DataSource = stereoPairView;
        }

        private void _loadStereoPairMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = UIStrings.LoadStereoPair;
            ofd.Filter = string.Format("{0} (*.sp)|*.sp|{1}|*.*", "Stereo pair files", "All Files");
            ofd.FilterIndex = 0;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            IStreoPairLoaderSaver ls = new JsonStereoPairLoaderSaver();
            var sp = ls.LoadStereoPair(new Uri(ofd.FileName));

            StereoPairView stereoPairView = new StereoPairView();
            stereoPairView.Name = sp.Name;
            stereoPairView.WorkSpace = Path.GetDirectoryName(ofd.FileName);
            stereoPairView.FileNameImageLeft = sp.FileNameImageLeft;
            stereoPairView.FileNameImageRight = sp.FileNameImageRight;
            stereoPairView.Basis = sp.Basis;
            stereoPairView.FX = sp.FX;
            stereoPairView.FY = sp.FY;
            stereoPairView.CX = sp.CX;
            stereoPairView.CY = sp.CY;

            _stereoPairViewControl.DataSource = stereoPairView;
        }
    }
}
