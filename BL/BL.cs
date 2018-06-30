using System;
using System.Collections.Generic;
using System.Reflection;
using Biderman.PwZal.CORE;
using Biderman.PwZal.DAO;
using BL.Properties;

namespace Biderman.PwZal.BL
{
    public class BuisnessLogic : IBL
    {
        private IDAO _dao;
        public BuisnessLogic()
        {
            Assembly a = Assembly.UnsafeLoadFrom(Settings.Default.DataBaseAdress);
            Type dao_class = a.GetType(Settings.Default.DataBaseName);
            _dao = (IDAO)Activator.CreateInstance(dao_class, new object[] {});

        }

        public void AddManuf(IManufacturer manufacturer)
        {
            _dao.AddManuf(manufacturer);
        }

        public void AddProduct(IProduct product)
        {
            _dao.AddProduct(product);
        }

        public ICollection<IManufacturer> GetAllManufs()
        {
            return _dao.AllManufs();
        }

        public ICollection<IProduct> GetAllProducts()
        {
            return _dao.AllProducts();
        }

        public void RemoveManuf(IManufacturer manufacturer)
        {
            _dao.RemoveManuf(manufacturer);
        }

        public void RemoveProduct(IProduct product)
        {
            _dao.RemoveProduct(product);
        }
    }
}
