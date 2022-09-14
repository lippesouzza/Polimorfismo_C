using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1.Src
{
	internal class Onivoros
	{
		public Onivoros Onivoro { get; set; }
		public Onivoros()
		{

		}

		public Onivoros(Onivoros onivoro)
		{
			Onivoro = onivoro;
		}

		public override string ToString()
		{
			return "Então esse animal come de tudo";
		}
	}
}