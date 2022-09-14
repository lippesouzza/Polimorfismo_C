using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1.Src
{
    internal class Herbivoros
    {
        public Herbivoros Herbivoro { get; set; }
        public Herbivoros()
        {

        }

        public Herbivoros(Herbivoros herbivoro)
        {
            Herbivoro = herbivoro;
        }

        public override string ToString()
        {
            return "Então esse animal come plantas";
        }
    }
}