using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema_1.Lucrul_cu_clasele
{
    //Cream clasa cerc

    class Cerc
    {
        //Proprietatea clasei lungimea razei
        public double lungimeaRazei { get; set; }

        //Metoda de initializare
        public Cerc()
        {

        }

        //Metoda Citire pentru citirea datelor despre cerc
        public void Citire()
        {
            Console.Write("Lungimea razei : ");
            lungimeaRazei = double.Parse(Console.ReadLine());
        }

        //Metoda Afisare pentru afisarea datelor despre cerc
        public void Afisare()
        {
            Console.WriteLine($"Lungimea razei : {lungimeaRazei}");

            Console.WriteLine($"Lungimea : {DeterminareLungimeCerc():F2}");

            Console.WriteLine($"Suprafata : {DeterminareSuprafataCerc():F2}");

            Console.WriteLine($"Diametrul : {DeterminareDiametruCerc()}");
        }

        //Metoda DeterminareLungimeCerc pentru determinarea lungimii cercului
        public double DeterminareLungimeCerc() => 2 * Math.PI * lungimeaRazei;


        //Metoda DeterminareSuprafataCerc pentru determinarea suprafetei cercului
        public double DeterminareSuprafataCerc() => Math.PI * lungimeaRazei * lungimeaRazei;

        //Metoda DeterminareDiametruCerc pentru determinarea diametrului cercului
        public double DeterminareDiametruCerc() => 2 * lungimeaRazei;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cream o lista in care vor fi adaugate datele depre instantele clasei Cerc
            List<Cerc> listaCercuri = new List<Cerc>();

            for (int i = 0; i < 2; i++)
            {
                //Instanta clasei Cerc
                Cerc cerc = new Cerc();

                //Citim datele de la tastatura despre instante
                Console.WriteLine("Citim datele despre cercul " + (i + 1) + " : ");
                cerc.Citire();

                //Spatiu
                Console.WriteLine();

                //Adaugam instanta in Lista cercuri
                listaCercuri.Add(cerc);
            }

            //Afisam datele despre cercul cu suprafata cercului maxima

            Console.WriteLine("----<Informatia despre cercul cu suprafata maxima>----");

            double suprafataMax = listaCercuri.Max(cerc => cerc.DeterminareSuprafataCerc());
            var suprafataCercMax = listaCercuri.First(cerc => cerc.DeterminareSuprafataCerc() == suprafataMax);

            suprafataCercMax.Afisare();

            //Spatiu  
            Console.WriteLine();

            //Afisam datele despre cercul cu lungimea cercului minima

            Console.WriteLine("----<Informatia despre cercul cu lungimea discului minima>----");

            double lungimeMin = listaCercuri.Min(cerc => cerc.DeterminareLungimeCerc());
            var lungimeCercMin = listaCercuri.First(cerc => cerc.DeterminareLungimeCerc() == lungimeMin);

            lungimeCercMin.Afisare();

            Console.ReadKey();
        }
    }
}
