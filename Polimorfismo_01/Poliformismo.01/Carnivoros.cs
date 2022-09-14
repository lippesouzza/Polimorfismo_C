using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1.Src
{
	internal class Carnivoros
	{
		public Carnivoros Carnivoro { get; set; }
		public Carnivoros()
		{

		}

		public Carnivoros(Carnivoros carnivoro)
		{
			Carnivoro = carnivoro;
		}

		public override string ToString()
		{
			return "Então esse animal come carne";
		}
	}
}