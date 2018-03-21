using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Car : Zabawka, IAccelerate
    {
        public Car(string name) : base(name)
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
