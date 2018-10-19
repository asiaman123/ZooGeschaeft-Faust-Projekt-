using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Reptil : Tier
    {

        public Boolean giftig;

        public Reptil (double preis, double gewicht, double groesse, Boolean giftig) : base(preis, gewicht, groesse)
        {
            this.preis = preis;
            this.gewicht = gewicht;
            this.groesse = groesse;
            this.giftig = giftig;
        }
    }
}
