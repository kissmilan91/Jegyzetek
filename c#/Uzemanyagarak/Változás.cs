using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407_Uzemanyagarak
{
    class Változás
    {
        public DateTime Dátum { get; private set; }
        public int Benzinár { get; private set; }
        public int Gázoljaár { get; private set; }

        public int Különbség
        {
            get
            {
                return Math.Abs(Benzinár - Gázoljaár);
            }
        }

        public bool Szökőnap
        {
            get
            {
                return this.Dátum.Year % 4 == 0 && this.Dátum.Month == 2 && this.Dátum.Day == 24;
            }
        }

        public Változás(string sor)
        {
            //2011.01.12;363;354
            string[] adatok = sor.Split(';');
            this.Dátum = DateTime.Parse(adatok[0]);
            this.Benzinár = int.Parse(adatok[1]);
            this.Gázoljaár = int.Parse(adatok[2]);
        }

        public Változás(DateTime dátum, int benzinár, int gázolajár)
        {
            this.Dátum = dátum;
            this.Benzinár = benzinár;
            this.Gázoljaár = gázolajár;
        }
    }
}
