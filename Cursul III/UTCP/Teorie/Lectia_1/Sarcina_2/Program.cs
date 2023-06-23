using System;

namespace Sarcina_2
{
    class Program
    {
        //Realizați un proiect ce conține o metodă ce va calcula a^n

        private static double Putere(int a, int n)
        {
            if (n == 0) { return 1; }
            else { return a * Putere(a, n - 1); }
        }
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("{0}^{1} = {2}", a, n, Putere(a, n));

                    Console.WriteLine("Mai efectuam niste calcule ? D/N:");
                    char c = char.Parse(Console.ReadLine());
                    if (char.ToUpper(c) == 'D')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.\n");
                    flag = true;
                }
            } while (flag);

            Console.ReadKey();
        }
    }
}
