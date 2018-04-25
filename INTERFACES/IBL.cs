using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biderman.PwZal.DAO;

namespace Biderman.PwZal.BL
{
    public interface IBL
    {
        ICollection<IManufacturer> GetAllManufs();
        ICollection<IProduct> GetAllProducts();
    }
}
