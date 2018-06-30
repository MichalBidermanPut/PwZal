using Biderman.PwZal.BL;
using Biderman.PwZal.DAO;
using System.Collections.Generic;
using System.Windows;

namespace GuiWpf
{
    public partial class MainWindow : Window
    {
        /*
        private IBL _bl;
        public ICollection<IManufacturer> ManufCollection { get { return _bl.GetAllManufs(); } }
        private IManufacturer _selectedManufacturer;
        public IManufacturer SelectedManufacturer {
            get { return _selectedManufacturer; }
            set { _selectedManufacturer = value; }
        }
        //public ManufListView manufListView;
        public ICollection<IProduct> ProductsCollection { get { return _bl.GetAllProducts(); } }
        */
        public MainWindow()
        {
            InitializeComponent();
            //manufListView = new ManufListView(_bl.GetAllManufs());
            //ManufList.ItemsSource = ManufCollection;
        }
    }
}