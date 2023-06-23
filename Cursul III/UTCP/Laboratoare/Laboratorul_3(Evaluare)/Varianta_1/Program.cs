using System;

namespace Varianta_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    int m = int.Parse(Console.ReadLine());

                    Console.WriteLine("Rezultat functie recursiva ({0},{1})={2}", n, m, CRecursiv(n, m));

                    Console.WriteLine("Rezultat functie iterativa ({0},{1})={2}", n, m, CIterativ(n, m));

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

        //Metoda iterativa
        private static int CIterativ(int n, int m)
        {
            return fact(n) / (fact(m) * fact(n - m));
        }
        private static int fact(int z)
        {
            int f = 1;
            for (int i = 1; i <= z; i++)
            {
                f *= i;
            }
            return f;
        }

        //Metoda recursiva
        private static int CRecursiv(int n, int m)
        {
            if (m == 0 || m == n)
            {
                return 1;
            }
            else
            {
                return CRecursiv(n - 1, m) + CRecursiv(n - 1, m - 1);
            }
        }
    }
}