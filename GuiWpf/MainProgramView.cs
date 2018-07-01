using Biderman.PwZal.BL;
using Biderman.PwZal.CORE;
using GuiWpf.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GuiWpf 
{
    public class MainProgramView : ObservableObject
    {
        private IBL _bl;
        private ICollection<IManufacturer> _manufCollection;
        private ICollection<IProduct> _productCollection;
        private ObservableCollection<IManufacturer> _observableManufCollection;
        private IManufacturer _currManuf;
        private IProduct _currProduct;
        private IManufacturer _tmpManuf;
        private IProduct _tmpProduct;
        public MainProgramView()
        {
            _bl = new BuisnessLogic(Settings.Default.DataBaseAdress, Settings.Default.DataBaseName);
            _manufCollection = new LinkedList<IManufacturer>(_bl.GetAllManufs());
            _productCollection = new LinkedList<IProduct>(_bl.GetAllProducts());
            _currManuf = null;
            _currProduct = null;
            _tmpManuf = new Manufacturer("");
            _tmpProduct = new Product("");
            _observableManufCollection = new ObservableCollection<IManufacturer>();
            foreach(var e in _manufCollection)
            {
                if (e != null) _observableManufCollection.Add(new Manufacturer(e));
            }
        }
        public ICommand AddProductCommand
        {
            get { return new DelegateCommand(AddProduct); }
        }
        private void AddProduct()
        {
            if (_tmpProduct.Id < 0)
            {
                MessageBox.Show("The Id field shouldn't have negative value");
                return;
            }
            else{
                foreach(var e in _productCollection)
                {
                    if (e.Id== _tmpProduct.Id)
                    {
                        MessageBox.Show("The Id can't have a repeated value");
                        return;
                    }
                }
                _bl.AddProduct(_tmpProduct);
                _productCollection = new LinkedList<IProduct>();
                foreach (var e in _bl.GetAllProducts())
                {
                    if (e != null) _productCollection.Add(e);
                }
                RaisePropertyChangedEvent("ProductCollection");
                _tmpProduct = new Product("", 0);
            }

        }
        public ICommand RemoveProductCommand
        {
            get { return new DelegateCommand(RemoveProduct); }
        }
        private void RemoveProduct()
        {
            _bl.RemoveProduct(_currProduct);
            _productCollection = new LinkedList<IProduct>();
            foreach (var e in _bl.GetAllProducts())
            {
                if (e != null) _productCollection.Add(e);
            }
            RaisePropertyChangedEvent("ProductCollection");
        }
        public ICommand AddManufCommand
        {
            get { return new DelegateCommand(AddManuf); }
        }
        private void AddManuf()
        {
            if (_tmpManuf.Id < 0)
            {
                MessageBox.Show("The Id field shouldn't have negative value");
                return;
            }
            else
            {
                foreach (var e in _manufCollection)
                {
                    if (e.Id == _tmpManuf.Id)
                    {
                        MessageBox.Show("The Id can't have a repeated value");
                        return;
                    }
                }
                _bl.AddManuf(_tmpManuf);
                _manufCollection = new LinkedList<IManufacturer>();
                foreach (var e in _bl.GetAllManufs())
                {
                    if (e != null) _manufCollection.Add(e);
                }
                _tmpManuf = new Manufacturer("", 0);
                RaisePropertyChangedEvent("ManufCollection");
            }
        }
        public ICommand RemoveManufCommand
        {
            get { return new DelegateCommand(RemoveManuf); }
        }
        private void RemoveManuf()
        {
            _bl.RemoveManuf(_currManuf);
            _manufCollection = new LinkedList<IManufacturer>();
            foreach (var e in _bl.GetAllManufs())
            {
                if (e != null) _manufCollection.Add(e);
            }
            RaisePropertyChangedEvent("ManufCollection");
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
        public IManufacturer TmpManuf
        {
            get
            {
                return _tmpManuf;
            }
            set
            {
                _tmpManuf = value;
                RaisePropertyChangedEvent("TmpManuf");
            }
        }
        public IProduct TmpProduct
        {
            get
            {
                return _tmpProduct;
            }
            set
            {
                _tmpProduct = value;
                RaisePropertyChangedEvent("TmpProduct");
            }
        }

    }

}
