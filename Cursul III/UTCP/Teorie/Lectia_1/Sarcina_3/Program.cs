using System;

namespace Sarcina_3
{
    class Program
    {
        //Calculam  factorialul numarului n prin metoda recursiva 

        private static int Factorial(int n)
        {
            if (n == 0) return 1;
            else { return n * Factorial(n - 1); }
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, Factorial(n));

            Console.ReadKey();
        }
    }
}
