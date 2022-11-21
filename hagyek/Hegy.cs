using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagyek
{
    internal class Hegy
    {
        private string csucs;
        private string hegyseg;
        private int magassag;
        private double magassagLabban;

        public Hegy(string csucs, string hegyseg, int magassag)
        {
            this.csucs = csucs;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
            this.magassagLabban = 3.28 * Convert.ToDouble(magassag);
        }

        public string Csucs { get => this.csucs; set => this.csucs = value; }
        public string Hegyseg { get => this.hegyseg; set => this.hegyseg = value; }
        public int Magassag { get => this.magassag; set => this.magassag = value; }
        public double MagassagLabban { get => this.magassagLabban; set => this.magassagLabban = value;}

        public override string ToString()
        {
            return $"Hegycsúcs: {this.csucs}, hegység: {this.hegyseg}, magassága: {this.magassag} m.";
        }
    }
}