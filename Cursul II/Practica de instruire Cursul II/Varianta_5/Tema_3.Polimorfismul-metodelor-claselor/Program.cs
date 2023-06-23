using System;

namespace Tema_3.Polimorfismul_metodelor_claselor
{
    //Cream clasa Contor
    class Contor
    {

        //Metoda Incrementeaza, ce primește ca parametru un număr întreg și returnează numărul respectiv incrementat cu o unitate
        public static int Incrementeaza(int numar)
        {
            return ++numar;
        }

        // Metoda Incrementează, ce primește ca parametru un număr real și returnează numărul respectiv incrementat cu 0.1
        public static double Incrementeaza(double numar)
        {
            return numar + 0.1;
        }

        //Metoda Incremenează, ce primește ca parametru un caracter și returnează caracterul specific codului ascii al caracterului inițial, incrementat cu o valoare.
        public static int Incrementeaza(char caracter)
        {
            int numar = (int)caracter;

            return numar += 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Afisarea primei metode
            Console.WriteLine($"Prima metoda incrementeaza un numar intreg 3 cu o unitate : " + Contor.Incrementeaza(3));

            Console.WriteLine();

            //Afisare a doua metoda
            Console.WriteLine($"A doua metoda incrementeaza un numar real 20.5 cu 0.1 : {Contor.Incrementeaza(20.5):F1} ");

            Console.WriteLine();

            //Afisare a treia metoda
            Console.WriteLine("A treia metoda primeste un caracter <<!>> si returnează caracterul specific codului ascii incrementat " +
                "cu o valoare  care este <<2>> : " + Contor.Incrementeaza('!'));

            Console.ReadKey();
        }
    }
}
