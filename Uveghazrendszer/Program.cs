namespace Uveghazrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kezelo k1 = new Kezelo("Kovács Péter", "kpeter", Szerepkor.ADMIN);
            Kezelo k2 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

            NovenyFaj n1 = new NovenyFaj("Para", 100, 10, 10);
			NovenyFaj n2 = new NovenyFaj("Paprika", 100, 10, 10);
			//Cella c1 = new Cella(new Pozicio(0, 0));
			//Console.WriteLine(c1.UresCella);
			//c1.Beultet(n1, 5);
			//Console.WriteLine(c1.UresCella);

			UveghazRacs uveghaz = new UveghazRacs(4);
			Console.WriteLine("TElepités: ");
            uveghaz.Telepit(1, 1, n1, 3);
			Console.WriteLine("TElepités: ");
			uveghaz.Telepit(1, 1, n1, 1);
			Console.WriteLine("TElepités: ");
			uveghaz.Telepit(2, 2, n2, 10);
			Console.WriteLine("Növelés: ");
			uveghaz.Noveles(1, 1, 5);
			Console.WriteLine("Növelés: ");
			uveghaz.Noveles(2, 2, 10);
			uveghaz.Kiiratas();
		}
	}
}
