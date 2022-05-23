using System;
using System.Collections.Generic;
using System.Text;

namespace _20211208_Autok
{
    class Auto
    {
        //Suzuki Swift;2008;4;Kek
        public string Tipus { get; set; }
        public int Evjarat { get; set; }
        public int AjtokSzama { get; set; }
        public string Szin { get; set; }

        public Auto(string sor)
        {
            string[] adatok = sor.Split(';');
            Tipus = adatok[0];
            Evjarat = int.Parse(adatok[1]);
            AjtokSzama = int.Parse(adatok[2]);
            Szin = adatok[3];
        }

        public Auto(string tipus, int evjarat, int ajtokSzama = 5, string szin = "fehér")
        {
            Tipus = tipus;
            Evjarat = evjarat;
            AjtokSzama = ajtokSzama;
            Szin = szin;
        }

        public override string ToString()
        {
            return string.Format($"{Tipus} ({Evjarat})");
            //return string.Format("{0} ({1})", Tipus, Evjarat);
        }
    }
}
