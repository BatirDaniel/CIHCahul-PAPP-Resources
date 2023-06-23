using System;

namespace Sarcina_2
{
    //Sa se determine o radacina a ecuatiei ex + x2 – 3x= 0 
    //pe segmentul [-1,-0,5] cu precizia e = 0.001
    class Program
    {
        static void Main(string[] args)
        {
            double st = -1;
            double dr = -0.5;
            double e = 0.001;
            double x = SolutieDI(st, dr, e);
            Console.WriteLine("Solutia ecuatiei e^x + x^2 – 3x = 0 pe segmentul [-1,-0.5] cu e = 0,001 este : \nx = {0:F8}", x);
            Console.WriteLine("\nf({0}) = {1:F8}", x, f(x));
            Console.ReadKey();
        }
        private static double SolutieDI(double st, double dr, double e)
        {
            double x;
            do
            {
                x = (st + dr) / 2;//mijlocul segmentului[-1,-0,5]
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
            return Math.Exp(x) + x * x - 3 * x;
        }
    }
}

