using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    struct Wartosc
    {
        private float cena;
        private float wartoscSentymentalna;

        public Wartosc(float cena, float wartoscSentymentalna)
        {
            if (cena < 0.0 || wartoscSentymentalna < 0.0)
            {
                throw new ValidationException("wartość i cena nie mogą być mniejsze niż 0 PLN");
            }
            this.cena = cena;
            this.wartoscSentymentalna = wartoscSentymentalna;
        }

        public float Cena
        {
            get => cena;
            set
            {
                if (value < 0.0)
                {
                    throw new ValidationException("Cena nie może być mniejsza niż 0 PLN");
                }
                this.cena = value;
            }
        }
        public float WartoscSentymentalna
        {
            get => wartoscSentymentalna;

            set
            {
                if (value < 0.0)
                {
                    throw new ValidationException("Wartość sentymentalna nie może być mniejsza niż 0 PLN");
                }
                wartoscSentymentalna = value;
            }
        }
    }
}
