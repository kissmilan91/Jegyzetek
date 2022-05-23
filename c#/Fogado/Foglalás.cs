using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210324_Fogado
{
    class Foglalás
    {
        //Csorba Ede 16:30 2017.10.28-18:48
        public string Vezetéknév { get; private set; }
        public string Keresztnév { get; private set; }
        public TimeSpan Időpont { get; private set; }
        public string IdőpontString { get; private set; }
        public DateTime FoglalásIdeje { get; private set; }
        public string TeljesNév
        {
            get
            {
                return this.Vezetéknév + " " + this.Keresztnév;
            }
        }

        public Foglalás(string sor)
        {
            string[] adatok = sor.Split(' ');
            this.Vezetéknév = adatok[0];
            this.Keresztnév = adatok[1];
            this.IdőpontString = adatok[2];
            //this.Időpont = new TimeSpan(int.Parse(adatok[2].Split(':')[0]), int.Parse(adatok[2].Split(':')[1]), 0);
            this.Időpont = new TimeSpan(int.Parse(adatok[2].Substring(0, 2)),
                                        int.Parse(adatok[2].Substring(3, 2)),
                                        0);
            this.FoglalásIdeje = DateTime.ParseExact(adatok[3],"yyyy.MM.dd-HH:mm",CultureInfo.InvariantCulture);
        }
    }
}
