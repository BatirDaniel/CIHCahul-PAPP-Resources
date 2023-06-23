using System;

namespace Sarcina_1
{
    class Program
    {
        //Se va determina produsul dintre două numere întregi prin adunări repetate;

        private static int Inmultire(int a, int b)
        {
            if (b == 0) return 0;
            if (b == 1) return a;
            return a + Inmultire(a, b - 1);
        }
        static void Main(string[] args)
        {
            bool flag = false;
            int a = 0, b = 0, semnb, semna, a1, b1;

            do
            {
                try
                {
                    semnb = semna = 1;
                    Console.Clear();
                    Console.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = int.Parse(Console.ReadLine());
                    a1 = a;
                    b1 = b;
                    if (b < 0)
                    {
                        b1 = b * -1;
                        semnb = -1;
                    }
                    if (a < 0)
                    {
                        a1 = a * -1;
                        semna = -1;
                    }

                    Console.WriteLine("{0} * {1} = {2} ", a, b, Inmultire(a1, b1) * semnb * semna);
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
