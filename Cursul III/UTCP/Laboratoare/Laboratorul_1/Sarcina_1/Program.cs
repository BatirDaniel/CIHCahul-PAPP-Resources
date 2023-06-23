using System;

namespace Sarcina_1
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
                    int a, b;
                    Console.Write("a=");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("CMMDC({0},{1})={2}", a, b, cmmdc(a, b, out int nr));

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
        private static int cmmdc(int a, int b , out int nr)
        {
            if (a * b == 0) return nr = a + b;
            if (a > b) return cmmdc(a - b, b , out nr);
            else  return cmmdc(a, b - a , out nr);
        }
    }
}
