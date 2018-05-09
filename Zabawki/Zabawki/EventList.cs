using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class EventList<T> : List<T>
    {
        public delegate void eventType(T item, EventArgs eventArgs);
        public event eventType AddEvent;
        public event eventType LimitReached;
        public int Limit = 500;
        public new void Add(T item)
        {
            if (base.Count < this.Limit)
            {
                base.Add(item);
                AddEvent(item, new EventArgs());
            }
            else
            {
                LimitReached(item, new EventArgs());
            }
        }
    }
}
