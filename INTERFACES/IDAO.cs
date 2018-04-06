using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    public interface IDAO
    {
        IManufacturer[] AllManufs();
        IProduct[] AllProducts();
        void AddManuf(IManufacturer manufacturer);
        void AddManufs(IManufacturer[] manufacturers);
        void AddProduct(IProduct product);
        void AddProducts(IProduct[] products);
    }
}
