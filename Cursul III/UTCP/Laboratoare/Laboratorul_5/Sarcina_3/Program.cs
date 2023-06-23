using System;

namespace Sarcina_3
{
    //Sa se determine o radacina a ecuatiei 3cos(x) + 2sin(x 2 )2 – 3 = 0
    //pe segmentul [–3, –2] cu precizia e = 0,0001
    class Program
    {
        static void Main(string[] args)
        {
            double st = -3;
            double dr = -2;
            double e = 0.0001;
            double x = SolutieDI(st, dr, e);
            Console.WriteLine("Solutia ecuatiei 3cos(x) + 2sin(x2 )2 – 3 = 0 pe segmentul [–3, –2] cu e = 0,0001 este : \nx = {0:F8}", x);
            Console.WriteLine("\nf({0}) = {1:F8}", x, f(x));
            Console.ReadKey();
        }
        private static double SolutieDI(double st, double dr, double e)
        {
            double x;
            do
            {
                x = (st + dr) / 2;//mijlocul segmentului[-3,-2]
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
            return (3*Math.Cos(x)) + (2 * Math.Sin(x * x)) * 2 - 3;
        }
    }
}
