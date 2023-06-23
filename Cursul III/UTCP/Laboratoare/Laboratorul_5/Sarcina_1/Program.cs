using System;

namespace Sarcina_1
{
    //Sa se determine o radacina a ecuatiei x4+2x3-x-1 = 0
    //pe segmentul [0,1] cu precizia e = 0,000017
    class Program
    {
        static void Main(string[] args)
        {
            double st = 0;
            double dr = 1;
            double e = 0.000017;
            double x = SolutieDI(st, dr, e);
            Console.WriteLine("Solutia ecuatiei x4 + 2x3 - x -1 = 0 pe segmentul [0,1] cu e = 0,000017 este : \nx = {0:F8}",x);
            Console.WriteLine("\nf({0}) = {1:F8}",x,f(x));
            Console.ReadKey();
        }
        private static double SolutieDI(double st,double dr,double e)
        {
            double x;
            do
            {
                x = (st + dr) / 2;//mijlocul segmentului[0,1]
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
            return x * x * x * x + 2 * x * x * x - x - 1;
        }
    }
}
