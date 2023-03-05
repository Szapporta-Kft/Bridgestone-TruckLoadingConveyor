using Bridgestone.Warehouse.Loading.Conveyor.App.View;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Panel PanelMain
        {
            get { return this._PanelMain;  }
        }
    }
}