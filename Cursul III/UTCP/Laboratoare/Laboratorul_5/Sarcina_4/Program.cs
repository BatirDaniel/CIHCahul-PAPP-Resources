using System;

namespace Sarcina_4
{
    //Sa se determine o radacina a ecuatiei x5 + 7x3 – 2x2 -15 = 0
    //pe segmentul [1,2] cu precizia e = 0,00001
    class Program
    {
        static void Main(string[] args)
        {
            double st = 1;
            double dr = 2;
            double e = 0.00001;
            double x = SolutieDI(st, dr, e);
            Console.WriteLine("Solutia ecuatiei x5 + 7x3 – 2x2 -15 = 0 pe segmentul [1,2] cu e = 0,00001 este : \nx = {0:F8}", x);
            Console.WriteLine("\nf({0}) = {1:F8}", x, f(x));
            Console.ReadKey();
        }
        private static double SolutieDI(double st, double dr, double e)
        {
            double x;
            do
            {
                x = (st + dr) / 2;//mijlocul segmentului[1,2]
                if (f(st) * f(dr) < 0)
                {
                    dr = x;
                }
                else
                {
                    st = x;
                }
            }
            while (Math.Abs(dr - st) <= e);
            return x;
        }
        private static double f(double x)
        {
            return Math.Pow(x, 5) + 7 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 15;
        }
    }
}
