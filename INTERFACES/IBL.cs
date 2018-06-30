using Biderman.PwZal.CORE;
using Biderman.PwZal.DAO;
using System.Collections.Generic;

namespace Biderman.PwZal.BL
{
    public interface IBL
    {
        ICollection<IManufacturer> GetAllManufs();

        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        void AddManuf(IManufacturer manufacturer);
        void RemoveManuf(IManufacturer manufacturer);

        ICollection<IProduct> GetAllProducts();
    }
}