using System;

namespace Sarcina_1
{
    class Program
    {
        //Aplicatia transforma o expresie aritmetica in forma poloneza postfixata
        //exemplu : a+b se scrie ab+
        //a*(b+c) se scrie abc+*
        //Etapele de rezolvare :
        //1. Divide: imparte expresia aritmetica in doua subexpresii legate printrun
        //perator de prioritate minima ;
        //2. Stapaneste : transforma recursiv in forma poloneza cele doua subexpresii;
        //3. Combina : scrie cele doua subexpresii in forma poloneza urmate de operatorul
        //care le leaga.
        static void Main(string[] args)
        {
            //Matrice celor 4 operatori standard
            char[,] op = { { '+', '-' }, { '*', '/' } };
            //Citirea expresiei aritmetice
            Console.WriteLine("Introdu expresia aritmetica : ");
            string ex = Console.ReadLine();
            if(ex.Length == 0)
            {
                return;
            }
            Console.WriteLine("Forma poloneza postfixata a expresiei aritmetice {0} este : {1}",ex,FormaPoloneza(ex,0,ex.Length-1,op));
            Console.ReadKey();
        }

        private static string FormaPoloneza(string ex, int low, int high, char[,] op)
        {
            if (low == high)
            {
                return ex[low].ToString();
            }
            //Elimina parantrezele exterioare inutile
            while(ex[low] == '(' && ex[high] == ')' && Paranteze(ex,low,high))
            {
                low++;
                high--;
            }
            //cauta locul unde sirul poate fi rupt in doua
            for (int i = 0; i < op.Length; i++)
            {
                int nrp = 0;
                for (int j = high; j >= low; j--)
                {
                    if (ex[j] == '(')
                    {
                        nrp++;
                    }
                    if(ex[j] == ')')
                    {
                        nrp--;
                    }
                    //daca se afla inafara parantezelor si a gasit un operator cu prioritate adecvata
                    if (nrp == 0 && (ex[j] == op[i,0]) || (ex[j] == op[i,1]))
                    {
                        return FormaPoloneza(ex, j + 1, high, op) + ex[j];
                    }
                }
            }
            //daca sa ajuns aici, sirul nu a putut fi "rupt" in doua , deci expresia este incorecta
            return "Sirul este incorect !";
        }

        private static bool Paranteze(string ex, int low, int high)
        {
            int nrp = 0;//numarul de paranteze inchise si deschise
            for (int i = low+1; i < high; i++)
            {
                if (ex[i] == '(')
                {
                    nrp++;
                }
                if (ex[i] == ')')
                {
                    nrp--;
                }
                if (nrp < 0)//sa inchis o paranteza fara pereche , deci nu putem elimina parantezele exterioare 
                {
                    return false;
                }
            }
            return true; //parantezele exterioare pot fi eliminate
        }
    }
}
