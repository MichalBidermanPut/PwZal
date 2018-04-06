using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biderman.PwZal.DAO
{
    public interface IManufacturer
    {
        int Id { get; set; }
        string Nazwa { get; set; }
    }
}
