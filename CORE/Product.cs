using Biderman.PwZal.CORE;

namespace Biderman.PwZal.CORE
{
    public class Product : IProduct
    {
        private int _id;
        private string _nazwa;
        private State _stan;
        public int Id { get => _id; set => _id=value; }
        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        public State Stan { get => _stan; set => _stan = value; }
        public string DisplayedId
        {
            get
            {
                if (Id == -1)
                {
                    return "";
                }
                return Id.ToString();
            }
        }

        public Product(string nazwa, int id)
        {
            _nazwa = nazwa;
            _id = id;
            Stan = State.gotowy;
        }
        public Product(string nazwa)
        {
            _nazwa = nazwa;
            _id = -1;
            Stan = State.gotowy;
        }
    }
}
