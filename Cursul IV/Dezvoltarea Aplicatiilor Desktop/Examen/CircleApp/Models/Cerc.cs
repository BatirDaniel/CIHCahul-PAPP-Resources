using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Models
{
    public class Cerc
    {
        public double Raza { get; set; }

        public Cerc(double raza)
        {
            Raza = raza;
        }

        public double lungimeCerc
        {
            get { return 2 * Math.PI * Math.Sqrt(Raza) ; }
        }

        public double arieCerc
        {
            get { return Math.PI * Raza * 2; }
        }

        public override string ToString()
        {
            return "Raza: " + Raza + "; Lungime: " + lungimeCerc + "; Aria: " + arieCerc;
        }
    }
}
