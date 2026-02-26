using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class UveghazRacs
	{
		private int meret;
		Cella[,] kert;

		public UveghazRacs(int meret)
		{
			this.meret = meret;
			this.kert = new Cella[this.meret, this.meret];
			Parcellaz();
		}

		private void Parcellaz()
		{
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					this.kert[i, j] = new Cella(new Pozicio(i, j));
				}
			}
		}

		public Cella CellaLekerdez(int x, int y)
		{
			return kert[x - 1, y - 1];
		}

		public void Telepit(int x, int y, NovenyFaj noveny, int egyedszam)
		{
			bool sikeres = kert[x - 1, y - 1].Beultet(noveny, egyedszam);
			if (sikeres)
			{
				Console.WriteLine($"{noveny.Nev} beültetve a(z) {x}, {y} ágyásba");
			} else
			{
				Console.WriteLine($"{noveny.Nev} nem lett beültetve a(z) {x}, {y} ágyásba");
			}
		}

		public void Kiiratas()
		{
			Console.WriteLine();
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					if (kert[i,j].UresCella)
					{
						Console.Write($"| ÜRES ");
					} else
					{
						Console.Write($"| {kert[i,j].Noveny.Azonosito,3} {kert[i,j].EgyedSzam} db ");
					}
				}
				Console.Write("|");
				Console.WriteLine("\n------------------------------------------------------------------------------------");
			}
		}

		public void Noveles(int x, int y, int mennyiseg)
		{
			kert[x-1, y-1].Noveles(mennyiseg);
			Console.WriteLine($"{x}, {y} ágyás növénye, a(z) {kert[x-1,y-1].Noveny.Nev}, az új egyedszám {kert[x-1, y-1].EgyedSzam}");
			if (kert[x-1,y-1].Noveny.OptimalSuruseg > kert[x-1, y-1].EgyedSzam)
			{
				Console.WriteLine($"A {kert[x - 1, y - 1].EgyedSzam} db növény jól érzik magukat");
			} else
			{
				Console.WriteLine($"A növények sokan vannak, nem érzik jól magukat ({kert[x-1, y-1].EgyedSzam})");
				Csokkentes(x, y, Math.Abs(kert[x - 1, y - 1].Noveny.OptimalSuruseg - kert[x - 1, y - 1].EgyedSzam));

			}
		}

		public void Csokkentes(int x, int y, int mennyiseg)
		{
			kert[x - 1, y - 1].Csokkentes(mennyiseg);
			Console.WriteLine($"{x}, {y} ágyás növénye, a(z) {kert[x - 1, y - 1].Noveny.Nev}, az új egyedszám {kert[x - 1, y - 1].EgyedSzam}");
	
		}
	}
}
