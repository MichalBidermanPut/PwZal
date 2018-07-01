using Biderman.PwZal.CORE;

namespace Biderman.PwZal.CORE
{
    public interface IProduct
    {
        int Id { get; set; }
        string DisplayedId {get; }
        string Nazwa { get; set; }
        State Stan { get; set; } 
    }
}
