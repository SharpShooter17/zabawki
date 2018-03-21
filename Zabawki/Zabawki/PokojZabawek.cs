using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class PokojZabawek
    {
        public List<Zabawka> zabawki = new List<Zabawka>();

        public List<Zabawka> Zabawki
        {
            get
            {
                return zabawki;
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
