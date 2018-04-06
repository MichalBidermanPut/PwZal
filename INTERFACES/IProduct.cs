using Biderman.PwZal.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biderman.PwZal.DAO
{
    public interface IProduct
    {
        int Id { get; set; }
        string Nazwa { get; set; }
        State Stan { get; set; } 
    }
}
