using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        static void OsiagnietoLimit(Object item, EventArgs eventArgs)
        {
            Console.WriteLine("Osiagnieto limit zabawek.. sorka :/");
        }

        static void WzrosrWartosci(Object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Wartosc zabawki wzrosla");
        }

        static void Main(string[] args)
        {
            test2();

            Console.ReadKey();
        }

        static void test2()
        {
            Thread th = new Thread(thread);
            th.Start();
            th.Join();
        }

        static void thread()
        {
            PokojZabawek room = new PokojZabawek();

            room.Zabawki.AddEvent += DodanoZabawke;
            room.Zabawki.LimitReached += OsiagnietoLimit;

            Random rand = new Random();

            for(int i = 0; i < 1000; i++)
            {
                int a = rand.Next(0, 3);

                switch(a)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }

        }

        static void test1()
        {
            PokojZabawek room = new PokojZabawek();

            room.Zabawki.AddEvent += DodanoZabawke;
            room.Zabawki.LimitReached += OsiagnietoLimit;

            Car audi = new Car("Audi A4", WzrosrWartosci);
            Box chocolateBox = new Box("Chocolate", WzrosrWartosci);

            audi.WartoscBazowa.wzrostWartosciEvent += WzrosrWartosci;
            chocolateBox.WartoscBazowa.wzrostWartosciEvent += WzrosrWartosci;

            room.Zabawki.Add(audi);
            room.Zabawki.Add(chocolateBox);

            room.pokazZabawki();

            audi.Accelerate = 5;
            chocolateBox.Dive = 3;
            chocolateBox.Rise = 7;

            room.pokazZabawki();

            room.Zabawki.Add(new Car("Czolg", WzrosrWartosci));
            room.Zabawki.Add(new Car("Czolg", WzrosrWartosci));
            room.Zabawki.Add(new Car("Czolg", WzrosrWartosci));
            room.Zabawki.Add(new Car("Czolg", WzrosrWartosci));
            room.Zabawki.Add(new Car("Czolg", WzrosrWartosci));

            Wartosc w = audi.WartoscBazowa;
            w.Cena = 100;

            room.setAccelerate(3);
            room.setDive(4);
            room.setRise(7);
        }
    }
}
