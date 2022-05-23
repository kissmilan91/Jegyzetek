using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210324_footgolf
{
    class Versenyző
    {
        //Albert Laszlo;Felnott ferfi;HOLE HUNTERS;0;0;10;10;0;0;0;10
        public string Név { get; private set; }
        public string Kategória { get; private set; }
        public string Egyesület { get; private set; }
        public List<int> Pontszámok { get; private set; }
        public int Összpontszám
        {
            get
            {
                int összeg = 0;
                List<int> rendezett = this.Pontszámok;
                rendezett.Sort();
                for (int i = 0; i < rendezett.Count; i++)
                {
                    if (i < 2 && rendezett[i] > 0) összeg += 10;
                    else összeg += rendezett[i];
                }
                return összeg;
            }
        }

        public Versenyző(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Név = adatok[0];
            this.Kategória = adatok[1];
            this.Egyesület = adatok[2];
            this.Pontszámok = new List<int>();
            for (int i = 3; i < adatok.Length; i++)
            {
                this.Pontszámok.Add(int.Parse(adatok[i]));
            }
        }
    }
}
