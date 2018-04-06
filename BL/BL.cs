using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biderman.PwZal.DAO;

namespace Biderman.PwZal.BL
{
    public class BL : IBL
    {
        private IDAO _dao = new DAOMock();

        public IManufacturer[] GetAllManufs()
        {
            return _dao.AllManufs();
        }

        public IProduct[] GetAllProducts()
        {
            return _dao.AllProducts();
        }
    }
}
