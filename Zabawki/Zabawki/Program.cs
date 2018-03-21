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
            room.zabawki.Add( new Car("BMW") );
            room.zabawki.Add( new Box("pudlo") );
            room.pokazZabawki();
        }
    }
}
