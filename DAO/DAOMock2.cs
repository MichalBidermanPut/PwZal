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
        IProduct[] _products;
        IManufacturer[] _manufacturers;
        public DAOMock2()
        {
            int SIZE = 50;
            _products =  (new Product[SIZE]);
            _manufacturers = new Manufacturer[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                _products[i] = new Product("Inny produkt nr:" + i.ToString(), i);
                _manufacturers[i] = new Manufacturer("Inny producent nr:" + i.ToString(), i);
            }
        }

        public void AddManuf(IManufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public void AddManufs(Collection<IManufacturer> manufacturers)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void AddProducts(Collection<IProduct> products)
        {
            throw new NotImplementedException();
        }

        public ICollection<IManufacturer> AllManufs()
        {
            return _manufacturers;
        }

        public ICollection<IProduct> AllProducts()
        {
            return _products;
        }
    }
}
