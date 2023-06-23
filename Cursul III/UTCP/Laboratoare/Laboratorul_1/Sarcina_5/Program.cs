using System;

namespace Sarcina_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "batir daniel";
            Console.WriteLine("Numarul de vocale mici este : {0} ",vocale(s, s.Length));

            Console.ReadKey();
        }

        private static int vocale(string s,int nr)
        {
            if (nr == 0) return 0;
            else
            {
                if(s[nr-1] == 'a'||s[nr-1] == 'e'||s[nr-1] == 'i'||s[nr-1] == 'o'||s[nr-1] == 'u')
                {
                    return 1 + vocale(s,nr-1);
                }
            }
            return vocale(s,nr-1);
        }
    }
}
