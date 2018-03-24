using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Program
    {
        static void DodanoZabawke(Object item, EventArgs eventArgs)
        {
            Zabawka z = (Zabawka)item;
            Console.WriteLine("Dodano zabawke do pokoju: " + z.Name);
        }

        static void Main(string[] args)
        {
            PokojZabawek room = new PokojZabawek();
            room.Zabawki.AddEvent += DodanoZabawke;
            Car audi = new Car("Audi A4");
            Box chocolateBox = new Box("Chocolate");

            room.Zabawki.Add( audi );
            room.Zabawki.Add( chocolateBox );
            room.pokazZabawki();
            audi.Accelerate = 5;
            chocolateBox.Dive = 3;
            chocolateBox.Rise = 7;
            room.pokazZabawki();

            Console.ReadKey();
        }
    }
}
