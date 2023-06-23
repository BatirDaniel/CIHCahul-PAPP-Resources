using System;
using System.Collections.Generic;

namespace Sarcina_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                try
                {
                    Console.Clear();
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    List<int> listaNumerelor = new List<int>();
                    listaNumerelor = CreareLista(n);
                    Console.Write("\nLista initiala : ");
                    TiparesteLista(listaNumerelor);

                    List<int> pare = new List<int>();

                    List<int> impare = new List<int>();

                    Console.WriteLine("\nLista elemente pare a listei initiale : ");
                    ListaPar(listaNumerelor, n-1 ,pare);
                    tiparirepare(pare);

                    Console.WriteLine("\nLista elemente impare a listei initiale: ");
                    ListaImpar(listaNumerelor, n-1,impare);
                    tiparireimpare(impare);
                    f = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Date gresite !");
                }
                Console.ReadLine();
            }
        }

        //Metoda ce afiseaza lista de elemente impare 
        private static void tiparireimpare(List<int> impare)
        {
            foreach (int item in impare)
            {
                Console.Write("{0} ", item);
            }
        }

        //Metoda ce afiseaza lista de elemente pare 
        private static void tiparirepare(List<int> pare)
        {
            foreach(int el in pare)
            {
                Console.Write("{0} ", el);
            }
        }

        //Metoda ce contine o functie recursiva de calculare a numerelor impare din lista initiala
        private static void ListaImpar(List<int> listaNumerelor,int n,List<int> impare)
        {
            if (n < 0) return;
            else
            {
                ListaImpar(listaNumerelor, n - 1, impare);
                if (listaNumerelor[n] % 2 == 1)
                {
                    impare.Add(listaNumerelor[n]);
                }
            }
        }

        //Metoda ce contine o functie recursiva de calculare a numerelor pare din lista initiala
        private static void ListaPar(List<int> listaNumerelor,int n,List<int> pare)
        {
            if (n < 0) return;
            else
            {
                ListaPar(listaNumerelor, n - 1, pare);
                if (listaNumerelor[n] % 2 == 0)
                {
                    pare.Add(listaNumerelor[n]);
                }
            }
        }

        private static List<int> CreareLista(int n)
        {
            List<int> lista = new List<int>();
            Random element = new Random();
            for (int i = 0; i < n; i++)
            {
                lista.Add(element.Next(100));
            }
            return lista;
        }

        private static void TiparesteLista(List<int> listaNumerelor)
        {
            foreach (int item in listaNumerelor)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
