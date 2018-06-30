using Biderman.PwZal.CORE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    public class DAOMock : IDAO
    {
        List<IProduct> _products;
        List<IManufacturer> _manufacturers;
        public DAOMock()
        {
            int SIZE=20;
            IProduct[] products = (new Product[SIZE]);
            IManufacturer[] manufacturers = new Manufacturer[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                _products[i] = new Product("Produkt nr:" + i.ToString(), i);
                _manufacturers[i] = new Manufacturer("Producent nr:" + i.ToString(), i);
            }
            _products = new List<IProduct>(products);
            _manufacturers = new List<IManufacturer>(manufacturers);
        }

        public void AddManuf(IManufacturer manufacturer)
        {
            _manufacturers.Add(manufacturer);
        }

        public void AddManufs(Collection<IManufacturer> manufacturers)
        {
            _manufacturers.AddRange(manufacturers);
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public void AddProducts(Collection<IProduct> products)
        {
            _products.AddRange(products);
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
            foreach (var e in _manufacturers)
            {
                if (e.Id == manufacturer.Id)
                {
                    _manufacturers.Remove(e);
                }
            }
        }

        public void RemoveProduct(IProduct product)
        {
            foreach (var e in _products)
            {
                if (e.Id == product.Id)
                {
                    _products.Remove(e);
                }
            }
        }
    }
}
