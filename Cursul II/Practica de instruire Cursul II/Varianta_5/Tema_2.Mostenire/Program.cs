using System;

namespace Tema_2.Mostenire
{
    //Cream clasa Persoana
    class Persoana
    {
        //Proprietatile clasei 
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public int AnulNasterii { get; set; }
        public string CNP { get; set; }

        //Metoda Citire pentru citirea datelor despre persoane
        public void Citire()
        {
            Console.Write("Numele : ");
            Nume = Console.ReadLine();

            Console.Write("Prenumele : ");
            Prenume = Console.ReadLine();

            Console.Write("Anul nasterii : ");
            AnulNasterii = int.Parse(Console.ReadLine());

            Console.Write("CNP : ");
            CNP = Console.ReadLine();
        }

        //Metoda Afisare pentru afisarea datelor despre persoane
        public void Afisare()
        {
            Console.WriteLine($"Numele : {Nume}");

            Console.WriteLine($"Prenumele : {Prenume}");

            Console.WriteLine($"Anul nasterii : {AnulNasterii}");

            Console.WriteLine($"CNP : {CNP}");

            Console.WriteLine($"Varsta : {Varsta()}");
        }

        //Metoda Varsta care calculeaza varsta persoanei
        public double Varsta() => DateTime.Now.Year - AnulNasterii;
    }

    //Cream clasa Salariat care este derivata clasei persoana 
    class Salariat : Persoana
    {
        //Proprietatile clasei
        public double nrOreLucrate { get; set; }

        public double plataPerOra { get; set; }

        //Metoda Salariul care calculeaza salariul persoanei
        public double Salariul() => nrOreLucrate * plataPerOra;

        //Metoda Citire pentru citirea datelor despre salariat
        public void Citire()
        {
            Console.Write("Numarul de ore lucrate : ");
            nrOreLucrate = double.Parse(Console.ReadLine());

            Console.Write("Plata pentru o ora : ");
            plataPerOra = double.Parse(Console.ReadLine());

            base.Citire();
        }

        //Metoda Afisare pentru afisarea datelr despre persoana
        public void Afisare()
        {
            Console.WriteLine($"Numarul de ore lucrate : {nrOreLucrate}");

            Console.WriteLine($"Plata pentru o ora : {plataPerOra}");

            base.Afisare();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instanta clasei Salariat
            Salariat salariat = new Salariat();

            //Citim datele despre salariat
            Console.WriteLine("Citim datele despre salariat : ");

            salariat.Citire();

            //Spatiu
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            //Afisam datele despre salariat
            Console.WriteLine("Informatiile despre salariat: ");

            salariat.Afisare();

            Console.ReadKey();
        }
    }
}
