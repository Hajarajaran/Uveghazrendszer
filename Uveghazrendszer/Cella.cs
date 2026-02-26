using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Cella
	{
		private Pozicio poz;
		private NovenyFaj noveny;
		private int egyedSzam;
		private List<Riasztas> riasztasok;
		private List<Szenzor> szenzorok;

		public Cella(Pozicio poz)
		{
			NovenyFaj noveny = null;
			this.poz = poz;
			egyedSzam = 0;
			riasztasok = new List<Riasztas>();
			szenzorok = new List<Szenzor>();
		}

		public int EgyedSzam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Poz { get => poz; set => poz = value; }
		internal NovenyFaj Noveny { get => noveny; set => noveny = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
	
		public bool UresCella
		{
			get
			{
				return this.noveny == null;
			}
		}
		public bool Beultet(NovenyFaj noveny, int egyedSzam)
		{
			if (this.UresCella)
			{
				this.noveny = noveny;
				this.egyedSzam = egyedSzam;
				if (this.egyedSzam > noveny.OptimalSuruseg)
				{
					this.noveny.EgeszsegiAllapot -= 2;
				}
				return true;
			}
			else if (noveny == this.noveny)
			{
				this.egyedSzam += egyedSzam;
				if (this.egyedSzam > noveny.OptimalSuruseg)
				{
					this.noveny.EgeszsegiAllapot -= 2;
				}
				return true;
			} else
			{
				return false;
			}
		}


		public void Noveles(int egyedSzam)
		{
			this.Beultet(this.noveny, this.egyedSzam);
		}

		public void Csokkentes(int egyedSzam)
		{
			this.egyedSzam -= egyedSzam;
			if (this.egyedSzam <= 0)
			{
				this.Urit();
			}
		}

		public void Urit()
		{
			this.noveny = null;
			this.egyedSzam = 0;
		}

		public override string ToString()
		{
			return $"{this.noveny.Nev} {this.egyedSzam} db. állapot: {this.noveny.EgeszsegiAllapot}";
		}
	}
}
