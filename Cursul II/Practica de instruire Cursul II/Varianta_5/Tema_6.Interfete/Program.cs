using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema_6.Interfete
{
    class Program
    {
        //Cream interfata ISolution (ecuatii)
        interface Isolution
        {
            //Proprietatile interfetei
            public List<double> Koef { get; set; }

            public bool Existence();

            public void Root();
        }

        class Linear : Isolution
        {
            public double A { get; set;}

            public double B { get; set; }

            public List<double> Koef { get; set; }

            public bool Existence()
            {
                if (A == 0 )
                {
                    if (B == 0)
                    {
                        Console.WriteLine($"<<<<<<<< Ecuatia {A}x + {B} = 0 admite o mulțime infinită de soluții ! >>>>>>>>>");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"<<<<<<<< Ecuatia {A}x + {B} = 0 nu are solutii ! >>>>>>>>>");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine($"<<<<<< Ecuatia {A}x + {B} = 0 are solutii ! >>>>>>>>");         
                    return true;
                }
            }

            public void Root()
            {
                Console.Write("a = ");
                A = double.Parse(Console.ReadLine());

                Console.Write("b = ");
                B = double.Parse(Console.ReadLine());

                Koef = new List<double>();

                //Adaugam in lista coeficientii ecuatiei 

                Koef.Add(A);

                Koef.Add(B);

                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Lista coeficientilor ecuatiei de gradul 1: ");

                foreach (var item in Koef)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            public Linear(double a, double b)
            {
                A = a;
                B = b;
            }
            public Linear()
            {
                        
            }
        }

        class Square : Isolution
        {
            public double A { get; set; }

            public double B { get; set; }

            public double C { get; set; }
            public List<double> Koef { get; set; }

            public bool Existence()
            {
                double delta = B * B - 4 * A * C;

                if (delta >= 0)
                {
                    Console.WriteLine($"<<<<<<<< Ecuatia {A}x^2 + {B}x + {C} = 0 are solutii ! >>>>>>>>>");
                    return true;
                }
                else
                {
                    Console.WriteLine($"<<<<<<<< Ecuatia {A}x^2 + {B}x + {C} = 0 nu are solutii ! >>>>>>>>>");
                    return false;
                }
            }

            public void Root()
            {
                Console.Write("a = ");
                A = double.Parse(Console.ReadLine());

                Console.Write("b = ");
                B = double.Parse(Console.ReadLine());

                Console.Write("c = ");
                C = double.Parse(Console.ReadLine());

                Koef = new List<double>();

                //Adaugam coeficientii ecuatiei in lista

                Koef.Add(A);

                Koef.Add(B);

                Koef.Add(C);

                Console.WriteLine("------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("Lista coeficientilor ecuatiei de gradul 2: ");

                foreach(var item in Koef)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }

            public Square(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public Square()
            {

            }
        }
        static void Main(string[] args)
        {
            Linear linear = new Linear();

            Console.WriteLine("Citim datele despre ecuatia de gradul I :");
            linear.Root();

            Console.WriteLine("------------------------------------------");

            linear.Existence();

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();

            Square square = new Square();

            Console.WriteLine("Citim datele despre ecuatia de gradul II :");
            square.Root();

            Console.WriteLine("------------------------------------------");

            square.Existence();

            Console.ReadKey();
        }
    }
}
