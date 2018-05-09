using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class PokojZabawek
    {
        private EventList<Zabawka> zabawki = new EventList<Zabawka>();

        public EventList<Zabawka> Zabawki
        {
            get
            {
                return zabawki;
            }
        }

        public void setAccelerate(int accelerate)
        {
            foreach(Zabawka z in zabawki)
            {
                IAccelerate test = z as IAccelerate;
                if (test != null)
                {
                    test.Accelerate = accelerate;
                    Console.WriteLine("Zmiana predkosci dla zabawki: " + z.Name);
                }
            }
        }

        public void setDive(int dive)
        {
            foreach (Zabawka z in zabawki)
            {
                IDive test = z as IDive;
                if (test != null)
                {
                    test.Dive = dive;
                    Console.WriteLine("Zmiana glebokosci dla zabawki: " + z.Name);
                }
            }
        }

        public void setRise(int rise)
        {
            foreach (Zabawka z in zabawki)
            {
                IRise test = z as IRise;
                if (test != null)
                {
                    test.Rise = rise;
                    Console.WriteLine("Zmiana wzrostu dla zabawki: " + z.Name);
                }
            }
        }

        public void pokazZabawki()
        {
            foreach(Zabawka z in zabawki)
            {
                Console.WriteLine("Zabawka: " + z.Name);
                IAccelerate IAtest = z as IAccelerate;
                if (IAtest != null)
                {
                    Console.WriteLine("Accelerate: " + IAtest.Accelerate);
                }
                IDive IDtest = z as IDive;
                if (IDtest != null)
                {
                    Console.WriteLine("Dive: " + IDtest.Dive);
                }
                IRise IRtest = z as IRise;
                if (IRtest != null)
                {
                    Console.WriteLine("Rise: " + IRtest.Rise);
                }
            }
        }
    }
}
