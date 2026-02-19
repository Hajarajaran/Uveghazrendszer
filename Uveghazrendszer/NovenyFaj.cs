using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Novenyfaj
	{
		private string nev;
		private int vizigeny; // max 100, azon tul egeszsegi alapota romlik
		private int egeszsegiAllapot; // 0-10, ahol 0 elpusztult
		private int optimalSuruseg;

		public Novenyfaj(string nev, int vizigeny, int egeszsegiAllapot, int optimalSuruseg)
		{
			this.nev = nev;
			this.vizigeny = vizigeny;
			this.egeszsegiAllapot = egeszsegiAllapot;
			this.optimalSuruseg = optimalSuruseg;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => this.nev.Substring(0, 3); }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegiAllapot { get => egeszsegiAllapot; set => egeszsegiAllapot = value; }
		public int OptimalSuruseg { get => optimalSuruseg; set => optimalSuruseg = value; }


		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegiAllapot}";
		}
	
	}
}
