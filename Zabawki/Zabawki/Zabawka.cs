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

        public Zabawka(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        internal Wartosc WartoscBazowa { get => wartoscBazowa; set => wartoscBazowa = value; }
        public double Wiek { get => wiek; set => wiek = value; }
    }
}
