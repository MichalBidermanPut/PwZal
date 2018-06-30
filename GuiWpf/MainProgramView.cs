using Biderman.PwZal.BL;
using Biderman.PwZal.CORE;
using System.Collections.Generic;
using System.Windows.Input;

namespace GuiWpf 
{
    public class MainProgramView : ObservableObject
    {
        private IBL _bl;
        private ICollection<IManufacturer> _manufCollection;
        private IManufacturer _currManuf;
        private IManufacturer _tmpManuf;
        private ICollection<IProduct> _productCollection;
        private IProduct _currProduct;
        private IProduct _tmpProduct;
        private bool _tmpProductHidden=true;
        private bool _tmpManufHidden=true;
        public MainProgramView()
        {
            _bl = new BuisnessLogic();
            _manufCollection = _bl.GetAllManufs();
            _productCollection = _bl.GetAllProducts();
            _currManuf = null;
            _currProduct = null;
            _tmpManuf = null;
            _tmpProduct = null;
        }
        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(AddProduct); }
        }
        private void AddProduct()
        {
            if(_tmpProduct!=null)
            _bl.AddProduct(_tmpProduct);
        }
        public ICollection<IManufacturer> ManufCollection
        {
            get
            {
                return _manufCollection;
            }
            set
            {
                _manufCollection = value;
                RaisePropertyChangedEvent("ManufCollection");
            }
        }
        public IManufacturer CurrManuf
        {
            get
            {
                return _currManuf;
            }
            set
            {
                _currManuf = value;
                RaisePropertyChangedEvent("CurrManuf");
            }
        }
        public ICollection<IProduct> ProductCollection
        {
            get
            {
                return _productCollection;
            }
            set
            {
                _productCollection = value;
                RaisePropertyChangedEvent("ProductCollection");
            }
        }
        public IProduct CurrProduct
        {
            get
            {
                return _currProduct;
            }
            set
            {
                _currProduct = value;
                RaisePropertyChangedEvent("CurrProduct");
            }
        }
        /*
        public ManufListView(ICollection<IManufacturer> ManufListIn)
        {
            _manufList = ManufListIn;
            _currManuf = _manufList.First();
        }
        public ManufListView()
        {
            _manufList = null;
            _currManuf = null;
        }
        * /
        //private readonly TextConverter _textConverter = new TextConverter(s => s.ToUpper());
        private string _someText;
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(SomeText)) return;
            //AddToHistory(_textConverter.ConvertText(SomeText));
            SomeText = string.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
        */

    }

}
