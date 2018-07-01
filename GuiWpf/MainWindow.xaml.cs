using Biderman.PwZal.BL;
using Biderman.PwZal.CORE;
using Biderman.PwZal.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
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
            StatesComboBox.ItemsSource = Enum.GetValues(typeof(State)).Cast<State>();
            //manufListView = new ManufListView(_bl.GetAllManufs());
            //ManufList.ItemsSource = ManufCollection;
        }
    }
}