using System;
using System.Collections.Generic;
using System.IO;

namespace Tema_5.Utilizare_fisiere_binare
{
    //Cream clasa Universitate
    class Universitate
    {
        //Proprietatile clasei
        public string numeUniversitate { get; set; }

        public string Adresa { get; set; }

        public List<string> listaSpecialitati = new List<string>();

        public double nrMaximStudenti { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cream lista listaUniversitati in care vom adauga datele despre fiecare universitate

            List<Universitate> listaUniversitati = new List<Universitate>();

            listaUniversitati.Add(new Universitate() { numeUniversitate = "Universitatea de stat ''Bogdan Petri" +
                "ceicu Hasdeu'' ", Adresa = "str.Stefan cel Mare", listaSpecialitati = { "Matematica", "Informatica", "Fizica", "Limba Romana" }, nrMaximStudenti = 30 });

            listaUniversitati.Add(new Universitate() { numeUniversitate = "Universitatea de medicina" +
                " de stat ''Nicolae Testemiteanu'' ", Adresa = "str.Bihai Viteazu", listaSpecialitati = { "Chimia", "Fizica", "Anatomia" }, nrMaximStudenti = 29 });

            listaUniversitati.Add(new Universitate() { numeUniversitate = "Universitatea pedagogica" +
                " de stat ''Ion Creanga'' ", Adresa = "str.Stefan cel Mare", listaSpecialitati = { "Matematica", "Informatica", "Fizica", "Limba Romana" }, nrMaximStudenti = 31 });

            //Inscriem lista listaUniversitati intrun fisier binar
            using (BinaryWriter fisier = new BinaryWriter(File.Open("date.bin", FileMode.OpenOrCreate)))
            {
                //Cream un foreach prin care vom citi datele din lista listaUniversitati in fisierul "date.bin"
                foreach (var item in listaUniversitati)
                {
                    fisier.Write(item.numeUniversitate);

                    fisier.Write("\t");

                    fisier.Write(item.Adresa);

                    fisier.Write("\t");

                    //Mai cream inca un foreach prin care vom citi datele din lista listaSpecialitati in fisierul "date.bin" 
                    foreach (var elem in item.listaSpecialitati)
                    {
                        fisier.Write(elem + " ");
                    }

                    fisier.Write("\n\t");

                    fisier.Write(item.nrMaximStudenti.ToString());

                    fisier.Write("\n\n");
                }
            }
            Console.ReadKey();
        }
    }
}