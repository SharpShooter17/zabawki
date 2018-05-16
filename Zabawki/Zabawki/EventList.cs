using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zabawki
{
    class EventList<T> : List<T>
    {
        public delegate void eventType(T item, EventArgs eventArgs);
        public event eventType AddEvent;
        public event eventType LimitReached;
        public int Limit = 500;

        private static Mutex mut = new Mutex();

        public new void Add(T item)
        {
            mut.WaitOne();
            if (base.Count < this.Limit)
            {
                base.Add(item);
                AddEvent(item, new EventArgs());
            }
            else
            {
                LimitReached(item, new EventArgs());
            }
            mut.ReleaseMutex();
        }

        public new void RemoveAt(int index)
        {
            mut.WaitOne();
            base.RemoveAt(0);
            mut.ReleaseMutex();
        }

    }
}
