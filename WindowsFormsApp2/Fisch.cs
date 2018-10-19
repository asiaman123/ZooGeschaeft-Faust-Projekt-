using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Fisch : Tier
    {
        public int flosse { get; set; }

        public Fisch(double preis, double gewicht, double groesse, int flosse) : base(preis,gewicht,groesse)
        {
           
            this.gewicht = gewicht;
            this.groesse = groesse;
            this.flosse = flosse;
            this.preis = preis;

        }

    }
}
