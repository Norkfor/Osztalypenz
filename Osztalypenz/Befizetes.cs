using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalypenz
{
    class Befizetes
    {
        bool befizetett;
        string nev;
        int osszeg;
        DateTime datum;

        public bool Befizetett { get => befizetett; private set => befizetett = value; }
        public string Nev { get => nev; private set => nev = value; }
        public int Osszeg { get => osszeg; private set => osszeg = value; }
        public DateTime Datum { get => datum; private set => datum = value; }

        public Befizetes(bool befizetett, string nev, int osszeg, DateTime datum)
        {
            Befizetett = befizetett;
            Nev = nev;
            Osszeg = osszeg;
            Datum = datum;
        }

        public Befizetes(string adatok)
        {
            string[] a = adatok.Split(';');
            Befizetett = Convert.ToBoolean(a[0]);
            Nev = a[1];
            Osszeg = int.Parse(a[2]);
            Datum = Convert.ToDateTime(a[3]);
        }
    }
}
