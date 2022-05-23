using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class Forduló
    {
        public int Év { get; private set; }
        public int Hét { get; private set; }
        public int FordulóSzáma { get; set; }
        public int T13p1 { get; private set; }
        public int Ny13p1 { get; private set; }
        public string Eredmények { get; private set; }

        public Forduló(string sor)
        {
            //Év;Hét;Forduló;T13p1;Ny13p1;Eredmények
            string[] adatok = sor.Split(';');
            Év = int.Parse(adatok[0]);
            Hét = int.Parse(adatok[1]);
            FordulóSzáma = int.Parse(adatok[2]);
            T13p1 = int.Parse(adatok[3]);
            Ny13p1 = int.Parse(adatok[4]);
            Eredmények = adatok[5];
        }

    }
}
