using System;

namespace Sarcina_3
{
    class Program
    {
		static int p, i;

		//Functia recursiva
		private static void Cifre(int n, ref int p, ref int i)
		{
			if (n < 10)
			{
				if (n % 2 == 0)
				{
					p = n;
					i = 0;
				}
				else
				{
					p = 0;
					i = n;
				}
			}
			else
			{
				Cifre(n / 10, ref p, ref i);
				if (n % 2 == 0)
				{
					p = p * 10 + n % 10;
				}
				else
				{
					i = i * 10 + n % 10;
				}
			}
		}

		static void Main(string[] args)
        {
			Cifre(4536597, ref p, ref i);

	        Console.WriteLine("Numerele formate cu cifrele pare si impare a numarului 4536597 sunt : par = {0} si impar = {1}", p , i);
			Console.ReadKey();
        }
	}
}
