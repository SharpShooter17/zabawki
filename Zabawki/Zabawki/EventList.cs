using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class EventList<T> : List<T>
    {
        public delegate void objectAdded(T item, EventArgs eventArgs);
        public event objectAdded AddEvent;

        public new void Add(T item)
        {
            base.Add(item);
            AddEvent(item, new EventArgs());
        }
    }
}
