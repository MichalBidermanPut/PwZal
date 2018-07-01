using Biderman.PwZal.CORE;

namespace Biderman.PwZal.CORE
{
    public class Manufacturer :IManufacturer
    {
        private int _id;
        private string _nazwa;
        public int Id { get => _id; set => _id = value; }
        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        public Manufacturer(string nazwa, int id)
        {
            _nazwa = nazwa;
            _id = id;
        }
        public Manufacturer(string nazwa)
        {
            _nazwa = nazwa;
            _id = -1;
        }
    }
}
