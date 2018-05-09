using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Car : Zabawka, IAccelerate
    {
        public Car(string name, delegat handler) : base(name, handler)
        {
        }
        private int accelerate;
        public int Accelerate
        {
            get
            {
                return accelerate;
            }

            set
            {
                accelerate = value;
            }
        }
    }
}
