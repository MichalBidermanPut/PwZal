using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    public interface IDAO
    {
        ICollection<IManufacturer> AllManufs();
        ICollection<IProduct> AllProducts();
        void AddManuf(IManufacturer manufacturer);
        void AddManufs(Collection<IManufacturer> manufacturers);
        void AddProduct(IProduct product);
        void AddProducts(Collection<IProduct> products);
    }
}
