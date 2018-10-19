using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Vogel : Tier
    {
        public Boolean flug;
        public double flugweite;

        public Vogel(double preis, double gewicht, double groesse, Boolean flug, double flugweite) : base(preis, gewicht, groesse)
        {
            this.preis = preis;
            this.gewicht = gewicht;
            this.groesse = groesse;
            this.flug = flug;
            this.flugweite = flugweite;

        }

    }
}
