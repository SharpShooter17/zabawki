using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Box : Zabawka, IDive, IRise
    {
        public Box(string name) : base(name)
        {
        }

        private int dive;

        public int Dive
        {
            get
            {
                return dive;
            }

            set
            {
                dive = value;
            }
        }

        private int rise;

        public int Rise
        {
            get
            {
                return rise;
            }

            set
            {
                rise = value;
            }
        }
    }
}
