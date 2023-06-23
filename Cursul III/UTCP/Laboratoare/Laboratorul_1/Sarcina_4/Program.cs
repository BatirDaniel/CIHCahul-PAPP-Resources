using System;

namespace Sarcina_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("n = ");
                ulong n = ulong.Parse(Console.ReadLine());

                Console.WriteLine("Numarul format dupa eliminarea cifrelor impare a numarului {0} este : {1}", n, DeleteImpar(n));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.\n");
            }

            Console.ReadKey();
        }

        private static ulong DeleteImpar(ulong n)
        {
            if (n == 0) return 0;
            if (n % 2 == 1) return DeleteImpar(n / 10);
            else return DeleteImpar(n / 10) * 10 + n % 10;
        }
    }
}
