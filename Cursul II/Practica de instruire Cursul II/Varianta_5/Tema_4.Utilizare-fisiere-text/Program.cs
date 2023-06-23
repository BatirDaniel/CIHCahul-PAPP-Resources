using System;
using System.Collections.Generic;
using System.IO;

namespace Tema_4.Utilizare_fisiere_text
{
    //Cream clasa Melodie
    class Melodie
    {
        //Proprietatile clasei
        public string Denumire { get; set; }

        public string Interpret { get; set; }

        public DateTime dataLansarii { get; set; }

        public double Durata { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cream o lista in care o sa adaug cel putin datele despre 5 melodii
            List<Melodie> melodii = new List<Melodie>();

            melodii.Add(new Melodie() { Denumire = "I see you again - for Paul Walker", Interpret = "Wiz Khalifa",
                dataLansarii = DateTime.Parse("01/01/2013"), Durata = 150 });

            melodii.Add(new Melodie() { Denumire = "Unity", Interpret = "Alan Walker",
                dataLansarii = DateTime.Parse("08/08/2019"), Durata = 220 });

            melodii.Add(new Melodie() { Denumire = "Take away", Interpret = "Marshmello", 
                dataLansarii = DateTime.Parse("4/6/2019"), Durata = 200 });

            melodii.Add(new Melodie() { Denumire = "Something Just Like This", Interpret = "Coldplay & The Chainsmokers",
                dataLansarii = DateTime.Parse("10/12/2017"), Durata = 110 });

            melodii.Add(new Melodie() { Denumire = "Wonderland", Interpret = "Axel Johansson", 
                dataLansarii = DateTime.Parse("12/04/2020"), Durata = 92 });

            //Adaugam datele din lista melodii in fisierul date.out

            using (StreamWriter fisier = new StreamWriter("date.out"))
            {
                foreach (var item in melodii)
                    // <<//>> este spatiul dintre date
                    fisier.WriteLine(item.Denumire + "//" + item.Interpret + "//" + item.dataLansarii.ToString("dd/MM/yyyy") + 
                        "//" + item.Durata);
            }

            Console.ReadKey();
        }
    }
}
