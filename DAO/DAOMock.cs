using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    public class DAOMock : IDAO
    {
        private IProduct[] _products;
        private IManufacturer[] _manufacturers;
        public DAOMock()
        {
            int SIZE=20;
            _products = new Product[SIZE];
            _manufacturers = new Manufacturer[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                _products[i] = new Product("Produkt nr:" + i.ToString(), i);
                _manufacturers[i] = new Manufacturer("Producent nr:" + i.ToString(), i);
            }
        }

        public void AddManuf(IManufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public void AddManufs(IManufacturer[] manufacturers)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void AddProducts(IProduct[] products)
        {
            throw new NotImplementedException();
        }

        public IManufacturer[] AllManufs()
        {
            return _manufacturers;
        }

        public IProduct[] AllProducts()
        {
            return _products;
        }
    }
}
