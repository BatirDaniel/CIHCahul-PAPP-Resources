using System;
using System.Collections.Generic;

namespace Sarcina_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;
            while(f)
            {
                try
                {
                    Console.Clear();
                    Console.Write("n = ");
                    int n = int.Parse(Console.ReadLine());
                    List<int> listaNumerelor = new List<int>();
                    listaNumerelor = CreareLista(n);
                    Console.WriteLine("\nLista initiala : ");
                    TiparesteLista(listaNumerelor);
                    int pare = 0, impare = 0;
                    SumElementePare(listaNumerelor, n - 1, ref pare, ref impare);
                    Console.WriteLine("\nSuma elementelor pare este egala cu : {0}", pare);
                    Console.WriteLine("\nSuma elementelor impare este egala cu : {0}", impare);
                    f = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Date gresite !");
                }
                Console.ReadLine();
            }
        }
        private static List<int> CreareLista(int n)
        {
            List<int> lista = new List<int>();
            Random element = new Random();
            for (int i = 0; i < n; i++)
            {
                lista.Add(element.Next(20));
            }
            return lista;
        }

        private static void TiparesteLista(List<int> listaNumerelor)
        {
            foreach(int item in listaNumerelor)
            {
                Console.Write("{0} ", item);
            }
        }

        private static void SumElementePare(List<int> listaNumerelor,int n,ref int pare,ref int impare)
        {
            if(n<0)
            {
                return;
            }
            else
            {
                SumElementePare(listaNumerelor, n - 1, ref pare, ref impare);
                if(listaNumerelor[n]%2 == 0)
                {
                    pare += listaNumerelor[n];
                }
                else
                {
                    impare += listaNumerelor[n];
                }
            }
        }
    }
}
