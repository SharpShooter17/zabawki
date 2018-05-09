using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public delegate void delegat(object sender, EventArgs eventArgs);

    struct Wartosc
    {
        private float cena;
        private float wartoscSentymentalna;

        public event delegat wzrostWartosciEvent;

        public Wartosc(float cena, float wartoscSentymentalna, delegat eventHandler)
        {
            if (cena < 0.0f || wartoscSentymentalna < 0.0f)
            {
                throw new ValidationException("wartość i cena nie mogą być mniejsze niż 0 PLN");
            }
            this.cena = cena;
            this.wartoscSentymentalna = wartoscSentymentalna;
            this.wzrostWartosciEvent = eventHandler;
        }
        public float Cena
        {
            get
            {
                return cena;
            }

            set
            {
                if (value < 0.0f)
                {
                    throw new ValidationException("Cena nie może być mniejsza niż 0 PLN");
                }
                if (value > cena)
                {
                    wzrostWartosciEvent(this, new EventArgs());
                }
                cena = value;
            }
        }

        public float WartoscSentymentalna
        {
            get
            {
                return wartoscSentymentalna;
            }

            set
            {
                if (value < 0.0f)
                {
                    throw new ValidationException("Wartość sentymentalna nie może być mniejsza niż 0 PLN");
                }
                wartoscSentymentalna = value;
            }
        }
    }
}
