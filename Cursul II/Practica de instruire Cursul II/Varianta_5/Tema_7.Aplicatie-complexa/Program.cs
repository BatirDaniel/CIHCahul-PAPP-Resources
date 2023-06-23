
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Tema_7.Aplicatie_complexa
{
    class Program
    {
        class CriptoValuta
        {
            public string Nume { get; set; }

            public string Acronim { get; set; }

            public DateTime dataCrearii { get; set; }

            public double capitalPePiata { get; set; }

            public double nrTotalMonedeCePotFiMinate { get; set; }

            public double pretMedCriptoMonedaInZiuaInregistrarii { get; set; }
        }

        static List<CriptoValuta> listaCriptoValute = new List<CriptoValuta>();

        public static int ShowMenu()
        {
            int UserChoose_int = 0;
            bool ok;
            do
            {
                Console.WriteLine("1. Adauga o CriptoValuta :");

                Console.WriteLine("2. Exclude o CriptoValuta dupa acronim :");

                Console.WriteLine("3. Înscrie într-un fisier datele despre criptomonele cu capitalul de market de peste 10 miliarde de dolari :");

                Console.WriteLine("4. Afiseaza datele despre CriptoMonedele cu cel mai mic pret :");

                Console.WriteLine("5. Afiseaza datele despre o CriptoMoneda dupa acronim :");

                Console.WriteLine("6. Afisează lista tuturor CriptoMonedelor, în ordine descrescătoare a preturilor :");

                Console.WriteLine("7. Afisează criptomoneda cu cea mai mare vechime pe piată :");

                Console.WriteLine("8. Afisează criptomoneda cu cea mai mică vechime pe piată :");

                Console.WriteLine("0. Iesire:");

                Console.WriteLine("\nAlegeti o optiune ! ");

                string UserChoose = Console.ReadLine();
                ok = int.TryParse(UserChoose, out UserChoose_int);
                if (!ok)
                {
                    Console.WriteLine("Nu exista astfel de optiune !");
                }
            } while (!ok);
            return UserChoose_int;
        }

        static void Main(string[] args)
        {
            bool go = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("--------------< Meniul Aplicatiei >--------------" );

                Console.WriteLine();



                int UserChoose = ShowMenu();
                switch (UserChoose)
                {
                    case 1:
                        Console.WriteLine("1. Adauga o CriptoValuta :");

                        Console.WriteLine();

                        AddCriptoValuta();
                        break;

                    case 2:
                        Console.WriteLine("2. Exclude o CriptoValuta dupa acronim :");

                        Console.WriteLine();

                        DeleteCriptoValutaByAcronim();

                        break;

                    case 3:
                        Console.WriteLine("3. Înscrie într-un fisier datele despre criptomonele cu capitalul de market de peste 10 miliarde de dolari :");

                        Console.WriteLine();

                        WriteInFileByCapitalOver10MilDolar();

                        break;

                    case 4:
                        Console.WriteLine("4. Afiseaza datele despre CriptoMonedele cu cel mai mic pret :");

                        Console.WriteLine();

                        CriptoMonedaPretMin();

                        break;

                    case 5:
                        Console.WriteLine("5. Afiseaza datele despre o CriptoMoneda dupa acronim :");

                        Console.WriteLine();

                        DisplayCriptoMonedaByAcronim();

                        break;

                    case 6:
                        Console.WriteLine("6. Afisează lista tuturor CriptoMonedelor, în ordine descrescătoare a preturilor :");

                        Console.WriteLine();

                        ListCriptoMonedaSortDescByPret();

                        break;

                    case 7:
                        Console.WriteLine("7. Afisează criptomoneda cu cea mai mare vechime pe piată :");

                        Console.WriteLine();

                        DisplayCriptoMonedaMaxVeche();

                        break;

                    case 8:
                        Console.WriteLine("8. Afisează criptomoneda cu cea mai mică vechime pe piată :");

                        Console.WriteLine();

                        DisplayCriptoMonedaMinVeche();

                        break;

                    case 0:
                        go = false;
                        Console.WriteLine("Iesire");

                        Console.WriteLine("The application has closed !");
                        break;
                    default:
                        Console.WriteLine("Nu exista astfel de optiune !");
                        break;
                }
            } while (go);

            Console.ReadKey();
        }

        //Metoda pentru prima optiune din meniu
        private static void AddCriptoValuta()
        {
            Console.Clear();

            CriptoValuta criptoValuta = new CriptoValuta();

            Console.WriteLine("Citim datele despre CriptoValuta :");

            try
            {
                Console.Write("Numele : ");
                criptoValuta.Nume = Console.ReadLine();

                Console.Write("Acronim : ");
                criptoValuta.Acronim = Console.ReadLine();

                Console.Write("Data crearii : ");
                criptoValuta.dataCrearii = DateTime.Parse(Console.ReadLine());

                Console.Write("Capital pe piata : ");
                criptoValuta.capitalPePiata = double.Parse(Console.ReadLine());

                Console.Write("Numarul total de monede ce pot fi minate : ");
                criptoValuta.nrTotalMonedeCePotFiMinate = double.Parse(Console.ReadLine());

                Console.Write("Pretul mediu al criptomonedei în ziua înregistrării : ");
                criptoValuta.pretMedCriptoMonedaInZiuaInregistrarii = double.Parse(Console.ReadLine());

                listaCriptoValute.Add(criptoValuta);
            }
            catch (Exception e)
            {
                Console.WriteLine("MESAJUL DE EROARE !");

                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }

        //Metoda pentru a doua optiune din meniu
        private static void DeleteCriptoValutaByAcronim()
        {
            Console.Clear();

            Console.WriteLine("Scrieti acronimul criptovalutei care doriti sa o excludeti din lista de mai jos : ");

            foreach (var item in listaCriptoValute)
            {
                Console.WriteLine(item.Acronim);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();

            try
            {
                string acronim = Console.ReadLine();

                Console.Write("Find data by Acronim..");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");

                    Thread.Sleep(400);
                }

                var itemToRemove = listaCriptoValute.Single(r => r.Acronim == acronim);

                listaCriptoValute.Remove(itemToRemove);
                
                Console.WriteLine("\nCriptoValute has been deleted !");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nMesajul de EROARE : " + e.Message);
            }

            Console.WriteLine();
        }

        //Metoda pentru a treia optiune din meniu
        private static void WriteInFileByCapitalOver10MilDolar()
        {
            Console.Clear();

            using (StreamWriter fisier = new StreamWriter("fisier_capital_max_10_mil_dolar.out"))
            {
                foreach (var item in listaCriptoValute)
                {
                    if (item.capitalPePiata > 10000000)
                    {
                        fisier.WriteLine("Datele despre CriptoValuta : ");

                        fisier.WriteLine();

                        fisier.WriteLine($"Numele : {item.Nume}");

                        fisier.WriteLine($"Acronim : {item.Acronim}");

                        fisier.WriteLine($"Data crearii : {item.dataCrearii.ToString("dd/MM/yyyy")}");

                        fisier.WriteLine($"Capital pe piata : {item.capitalPePiata}");

                        fisier.WriteLine($"Numarul total de monede ce pot fi minate : {item.nrTotalMonedeCePotFiMinate}");

                        fisier.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {item.pretMedCriptoMonedaInZiuaInregistrarii}");

                        Console.WriteLine("Datele au fost inscrise in fisier !");
                    }
                    else
                    {
                        fisier.WriteLine("Nu exista CriptoValuta cu un capital mai mare de 10 miliarde dolar ! ");

                        Console.WriteLine("Nu exista CriptoValuta cu un capital mai mare de 10 miliarde dolar ! ");
                    }
                }
            }

            Console.WriteLine();
        }

        //Metoda pentru a patra optiune din meniu
        private static void CriptoMonedaPretMin()
        {
            Console.Clear();

            double pretMin = listaCriptoValute.Min(criptoValuta => criptoValuta.pretMedCriptoMonedaInZiuaInregistrarii);

            var criptoMonedaPretMin = listaCriptoValute.First(criptoValuta => criptoValuta.pretMedCriptoMonedaInZiuaInregistrarii == pretMin);

            //Afisarea datelor despre CriptoMoneda cu pretul minim
            Console.WriteLine($"Numele : {criptoMonedaPretMin.Nume}");

            Console.WriteLine($"Acronim : {criptoMonedaPretMin.Acronim}");

            Console.WriteLine($"Data crearii : {criptoMonedaPretMin.dataCrearii.ToString("dd/MM/yyyy")}");

            Console.WriteLine($"Capital pe piata : {criptoMonedaPretMin.capitalPePiata}");

            Console.WriteLine($"Numarul total de monede ce pot fi minate : {criptoMonedaPretMin.nrTotalMonedeCePotFiMinate}");

            Console.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {criptoMonedaPretMin.pretMedCriptoMonedaInZiuaInregistrarii}");

            Console.WriteLine();
        }

        //Metoda pentru a cincea optiune din meniu
        private static void DisplayCriptoMonedaByAcronim()
        {
            Console.Clear();

            Console.Write("Scrieti acronimul criptovalutei care doriti sa o afisati din lista de mai jos : ");

            Console.WriteLine();

            foreach(var item in listaCriptoValute)
            {
                Console.WriteLine(item.Acronim);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();

            try
            {
                string acronim = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Find data by Acronim...");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");

                    Thread.Sleep(400);
                }

                Console.WriteLine();

                var itemToDisplay = listaCriptoValute.Single(r => r.Acronim == acronim);

                //Afisare date despre CriptoValuta cu acronimul ales din lista

                Console.WriteLine("\nDatele despre CriptoValuta : ");

                Console.WriteLine($"Numele : {itemToDisplay.Nume}");

                Console.WriteLine($"Acronim : {itemToDisplay.Acronim}");

                Console.WriteLine($"Data crearii : {itemToDisplay.dataCrearii.ToString("dd/MM/yyyy")}");

                Console.WriteLine($"Capital pe piata : {itemToDisplay.capitalPePiata}");

                Console.WriteLine($"Numarul total de monede ce pot fi minate : {itemToDisplay.nrTotalMonedeCePotFiMinate}");

                Console.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {itemToDisplay.pretMedCriptoMonedaInZiuaInregistrarii}");

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nMesajul de EROARE : " + e.Message);
            }
        }

        //Metoda pentru a sasea optiune din meniu
        private static void ListCriptoMonedaSortDescByPret()
        {
            Console.Clear();

            List<CriptoValuta> SortedList = listaCriptoValute.OrderBy(o => o.pretMedCriptoMonedaInZiuaInregistrarii).ToList();
            SortedList.Reverse();

            Console.WriteLine("Lista de criptovalute sortate descrescator dupa pret : ");

            Console.WriteLine();

            foreach (var item in SortedList)
            {
                Console.WriteLine($"Numele : {item.Nume}");

                Console.WriteLine($"Acronim : {item.Acronim}");

                Console.WriteLine($"Data crearii : {item.dataCrearii.ToString("dd/MM/yyyy")}");

                Console.WriteLine($"Capital pe piata : {item.capitalPePiata}");

                Console.WriteLine($"Numarul total de monede ce pot fi minate : {item.nrTotalMonedeCePotFiMinate}");

                Console.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {item.pretMedCriptoMonedaInZiuaInregistrarii}");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //Mtoda pentru a saptea optiune din meniu
        private static void DisplayCriptoMonedaMaxVeche()
        {
            Console.Clear();

            DateTime dateVecheMax = listaCriptoValute.Min(criptoValuta => criptoValuta.dataCrearii);

            var criptoMonedaDateVecheMax = listaCriptoValute.First(criptoValuta => criptoValuta.dataCrearii == dateVecheMax);

            Console.WriteLine($"Numele : {criptoMonedaDateVecheMax.Nume}");

            Console.WriteLine($"Acronim : {criptoMonedaDateVecheMax.Acronim}");

            Console.WriteLine($"Data crearii : {criptoMonedaDateVecheMax.dataCrearii.ToString("dd/MM/yyyy")}");

            Console.WriteLine($"Capital pe piata : {criptoMonedaDateVecheMax.capitalPePiata}");

            Console.WriteLine($"Numarul total de monede ce pot fi minate : {criptoMonedaDateVecheMax.nrTotalMonedeCePotFiMinate}");

            Console.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {criptoMonedaDateVecheMax.pretMedCriptoMonedaInZiuaInregistrarii}");

            Console.WriteLine();
        }

        //Metoda pentru a opta optiune din meniu
        private static void DisplayCriptoMonedaMinVeche()
        {
            Console.Clear();

            DateTime dateVecheMin = listaCriptoValute.Max(criptoValuta => criptoValuta.dataCrearii);

            var criptoMonedaDateVecheMin = listaCriptoValute.First(criptoValuta => criptoValuta.dataCrearii == dateVecheMin);

            Console.WriteLine($"Numele : {criptoMonedaDateVecheMin.Nume}");

            Console.WriteLine($"Acronim : {criptoMonedaDateVecheMin.Acronim}");

            Console.WriteLine($"Data crearii : {criptoMonedaDateVecheMin.dataCrearii.ToString("dd/MM/yyyy")}");

            Console.WriteLine($"Capital pe piata : {criptoMonedaDateVecheMin.capitalPePiata}");

            Console.WriteLine($"Numarul total de monede ce pot fi minate : {criptoMonedaDateVecheMin.nrTotalMonedeCePotFiMinate}");

            Console.WriteLine($"Pretul mediu al criptomonedei in ziua inregistrarii : {criptoMonedaDateVecheMin.pretMedCriptoMonedaInZiuaInregistrarii}");

            Console.WriteLine();
        }
    }
}