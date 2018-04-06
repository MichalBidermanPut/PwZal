using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biderman.PwZal.BL;
using Biderman.PwZal.DAO;

namespace Biderman.PwZal.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBL _bl = new BL.BL();
            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (c == 'm')
                {
                    foreach (IManufacturer manuf in _bl.GetAllManufs())
                    {
                        Console.WriteLine(manuf.Id.ToString() + "):\t" + manuf.Nazwa);
                    }
                }
                else if (c == 'p')
                {
                    foreach (IProduct product in _bl.GetAllProducts())
                    {
                        Console.WriteLine(product.Id.ToString() + "):\t" + product.Nazwa +
                            ";\t--Stan=" + product.Stan.ToString());
                    }
                }
                else if (c == 'x')
                {
                    break;
                }
            }
        }
    }
}
