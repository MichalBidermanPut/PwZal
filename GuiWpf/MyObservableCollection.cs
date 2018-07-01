using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GuiWpf
{
    public class MyObservableCollection<Element> : ObservableCollection<Element>
    {
        public MyObservableCollection(ICollection<Element> elements)
        {
            foreach(var e in elements)
            {
                Add(e);
            }
        }
        public void Update(ICollection<Element> elements)
        {
            Clear();
            foreach (var e in elements)
            {
                Add(e);
            }
        }
    }
}
