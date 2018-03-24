using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zabawki
{ 
    public class Zabawka
    {
        private Wartosc wartoscBazowa;
        private double wiek;

        public double WartoscAktualna
        {
            get
            {
                return wiek * WartoscBazowa.WartoscSentymentalna + WartoscBazowa.Cena;
            }
        }

        private string name;

        public Zabawka(string name, delegat handler)
        {
            this.name = name;
            this.wartoscBazowa = new Wartosc(10.0f, 1.0f, handler);
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Wiek { get => wiek; set => wiek = value; }
        internal Wartosc WartoscBazowa { get => wartoscBazowa; set => wartoscBazowa = value; }
    }
}
