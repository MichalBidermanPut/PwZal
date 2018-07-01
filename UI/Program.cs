using Biderman.PwZal.BL;
using Biderman.PwZal.CORE;
using Biderman.PwZal.DAO;
using System;
using UI.Properties;

namespace Biderman.PwZal.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBL _bl = new BuisnessLogic(Settings.Default.DataBaseAdress, Settings.Default.DataBaseName);
            char c = 'h';
            while (true)
            {
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
                else if (c == 'q')
                {
                    break;
                }
                else if (c == 'h')
                {
                    Console.WriteLine(@"Press 'm' to show Manufacturers");
                    Console.WriteLine(@"Press 'p' to show Products");
                    Console.WriteLine(@"Press 'h' to show help");
                    Console.WriteLine(@"Press 'q' or 'x' to exit");
                }
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            }
        }
    }
}