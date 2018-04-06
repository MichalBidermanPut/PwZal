using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biderman.PwZal.CORE;

namespace Biderman.PwZal.DAO
{
    public class Product : IProduct
    {
        private int _id;
        private string _nazwa;
        private State _stan;
        public int Id { get => _id; set => _id=value; }
        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        public State Stan { get => _stan; set => _stan = value; }

        public Product(string nazwa, int id)
        {
            _nazwa = nazwa;
            _id = id;
        }
        public Product(string nazwa)
        {
            _nazwa = nazwa;
            _id = -1;
        }
    }
}
