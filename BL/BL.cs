using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Biderman.PwZal.DAO;
using BL.Properties;

namespace Biderman.PwZal.BL
{
    public class BL : IBL
    {
        private IDAO _dao;
        public BL()
        {
            Assembly a = Assembly.UnsafeLoadFrom(Settings.Default.DataBaseAdress);
            Type dao_class = a.GetType(Settings.Default.DataBaseName);
            _dao = (IDAO)Activator.CreateInstance(dao_class, new object[] {});

        }

        public ICollection<IManufacturer> GetAllManufs()
        {
            return _dao.AllManufs();
        }

        public ICollection<IProduct> GetAllProducts()
        {
            return _dao.AllProducts();
        }
    }
}
