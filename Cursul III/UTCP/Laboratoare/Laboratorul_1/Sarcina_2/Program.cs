using System;

namespace Sarcina_2
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.Write("n=");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("k=");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("Rezultat ({0},{1})={2}", n, k, Combin1(n, k));
                    Console.WriteLine("Numarul de apeluri a metodei Combin1 este : {0}",count);

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

        //Functia recursiva
        private static int Combin1(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }
            else
            {
                count++;
                return Combin1(n - 1, k) + Combin1(n - 1, k - 1);
            }
        }
    }
}
