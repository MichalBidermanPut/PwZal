﻿using Biderman.PwZal.CORE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    class DAOMock2 : IDAO
    {
        LinkedList<IProduct> _products;
        LinkedList<IManufacturer> _manufacturers;
        public DAOMock2()
        {
            int SIZE = 50;
            IProduct[] products =  (new Product[SIZE]);
            IManufacturer[] manufacturers = new Manufacturer[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                products[i] = new Product("Inny produkt nr:" + i.ToString(), i);
                manufacturers[i] = new Manufacturer("Inny producent nr:" + i.ToString(), i);
            }
            _products = new LinkedList<IProduct>(products);
            _manufacturers = new LinkedList<IManufacturer>(manufacturers);
        }

        public void AddManuf(IManufacturer manufacturer)
        {
            _manufacturers.AddLast(manufacturer);
        }

        public void AddManufs(Collection<IManufacturer> manufacturers)
        {
            foreach(var m in manufacturers)
            {
                _manufacturers.AddLast(m);
            }
        }

        public void AddProduct(IProduct product)
        {
            _products.AddLast(product);
        }

        public void AddProducts(Collection<IProduct> products)
        {
            foreach (var p in products)
            {
                _products.AddLast(p);
            }
        }

        public ICollection<IManufacturer> AllManufs()
        {
            return _manufacturers;
        }

        public ICollection<IProduct> AllProducts()
        {
            return _products;
        }

        public void RemoveManuf(IManufacturer manufacturer)
        {
            LinkedList<IManufacturer> manufacturers_tmp = new LinkedList<IManufacturer>();
            foreach (var e in _manufacturers)
            {
                if(e!=null && manufacturer!=null)if (e.Id != manufacturer.Id)
                {
                    manufacturers_tmp.AddLast(e);
                }
            }
            _manufacturers = manufacturers_tmp;
        }

        public void RemoveProduct(IProduct product)
        {
            LinkedList<IProduct> products_tmp = new LinkedList<IProduct>();
            foreach (var e in _products)
            {
                if (e.Id != product.Id)
                {
                    products_tmp.AddLast(e);
                    //_products.Remove(e);
                }
            }
            _products = products_tmp;
        }
    }
}
