using Biderman.PwZal.CORE;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Biderman.PwZal.DAO
{
    public interface IDAO
    {
        ICollection<IManufacturer> AllManufs();
        ICollection<IProduct> AllProducts();
        void AddManuf(IManufacturer manufacturer);
        void AddManufs(Collection<IManufacturer> manufacturers);
        void RemoveManuf(IManufacturer manufacturer);
        void AddProduct(IProduct product);
        void AddProducts(Collection<IProduct> products);
        void RemoveProduct(IProduct product);
    }
}
