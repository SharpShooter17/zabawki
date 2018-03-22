using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Program
    {
        static void Main(string[] args)
        {
            PokojZabawek room = new PokojZabawek();

            Car audi = new Car("Audi A4");
            Box chocolateBox = new Box("Chocolate");

            room.zabawki.Add( audi );
            room.zabawki.Add( chocolateBox );
            room.pokazZabawki();
            audi.Accelerate = 5;
            chocolateBox.Dive = 3;
            chocolateBox.Rise = 7;
            room.pokazZabawki();

            Console.ReadKey();
        }
    }
}
