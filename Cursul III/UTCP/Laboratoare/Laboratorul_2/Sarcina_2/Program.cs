using System;

namespace Sarcina_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Numarul de elemente ale masivului este egal cu : ");
                    int n = int.Parse(Console.ReadLine());
                    int[] num;
                    num = CrearesiTiparireMasiv(n);
                    Console.Write("\n\nScrie un numar : ");
                    int nr = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nNumarul {0} este intalnit in masiv de {1} ori ! ", nr, NumberOfMasiv(num,n-1,nr));
                    f = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Date gresite !");
                }
                Console.ReadLine();
            }
        }

        //Metoda pentru crearea si afisarea masivului generat random
        private static int[] CrearesiTiparireMasiv(int n)
        {
            int[] masiv = new int[n];
            Random element = new Random();
            Console.Write("\nMasivul initial : ");
            for (int i = 0; i < n; i++)
            {
                masiv[i] = element.Next(50);
                Console.Write("{0} ", masiv[i]);
            }
            return masiv;
        }

        //Metoda ce contine o functie recursiva pentru calcularea numarului citit de la tastatura nr de cate ori se el numarul in masiv
        private static double NumberOfMasiv(int[] num, int n, int nr)
        {
            if (n == 0) return 0;
            else
            {
                if (num[n] == nr)
                {
                    return 1 + NumberOfMasiv(num, n - 1, nr);
                }
                else return NumberOfMasiv(num, n - 1, nr);
            }
        }
    }
}
