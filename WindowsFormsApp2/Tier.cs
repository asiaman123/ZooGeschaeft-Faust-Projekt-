using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   abstract class Tier
    {
        private static int id = 0;
        public double preis { get; set; }
        public double gewicht { get; set; }
        public double groesse { get; set; }


        public Tier(double preis, double gewicht, double groesse)
        {
            this.preis = preis;
            this.gewicht = gewicht;
            this.groesse = groesse;
            id = id++;

        }
    }
}
