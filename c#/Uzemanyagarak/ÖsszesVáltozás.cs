using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407_Uzemanyagarak
{
    class ÖsszesVáltozás
    {
        private List<Változás> változások = new List<Változás>();

        public ÖsszesVáltozás(string fájl)
        {
            //foreach (var sor in File.ReadAllLines(fájl))
            //{
            //    válzotások.Add(new Változás(sor));
            //}
            File.ReadAllLines(fájl).ToList().ForEach(sor => változások.Add(new Változás(sor)));
        }

        public int VáltozásokSzáma
        {
            get
            {
                return változások.Count;
            }
        }

        public int LegkisebbKülönbség
        {
            get
            {
                //int minIndex = 0;
                //for (int i = 1; i < változások.Count; i++)
                //{
                //    if (változások[i].Különbség < változások[minIndex].Különbség)
                //        minIndex = i;
                //}
                //return változások[minIndex].Különbség;
                return változások.Min(v => v.Különbség);
            }
        }

        public int LegkisebbKülönbségekSzáma
        {
            get
            {
                //int db = 0;
                //foreach (var item in változások)
                //{
                //    if (item.Különbség == this.LegkisebbKülönbség)
                //        db++;
                //}
                //return db;
                //return változások.Count(v => v.Különbség == this.LegkisebbKülönbség);
                return változások.Where(v => v.Különbség == this.LegkisebbKülönbség).Count();
            }
        }

        public bool VoltVáltozásSzökőnapon
        {
            get
            {
                //foreach (var item in változások)
                //{
                //    if (item.Szökőnap) return true;
                //}
                //return false;
                return változások.Any(v => v.Szökőnap);
            }
        }

        public bool VoltMagasabbBenzin(int küszöb)
        {
            return változások.Any(v => v.Benzinár > küszöb);
        }

        //Mennyi volt a gázolaj átlagára a vizsgált időszakban?
        public double ÁtlagGázolajÁr
        {
            get
            {
                //int összeg = 0;
                //foreach (var item in változások)
                //{
                //    összeg += item.Gázoljaár;
                //}
                //return (double)összeg / változások.Count;
                return változások.Average(v => v.Gázoljaár);
            }
        }

        //Hány olyan változás volt, amikor a benzin drágább volt mint a gázolaj?
        public int BenzinDrágább
        {
            get
            {
                //int db = 0;
                //foreach (var item in változások)
                //{
                //    if (item.Benzinár > item.Gázoljaár)
                //        db++;
                //}
                //return db;
                return változások.Where(v => v.Benzinár > v.Gázoljaár).Count();
            }
        }

        //Adott napon mennyibe kerültek az üzemanyagok?
        public Változás Keresés(DateTime nap)
        {
            //foreach (var item in változások)
            //{
            //    if (item.Dátum == nap)
            //        return item;
            //}
            //return null;
            return változások.FirstOrDefault(v => v.Dátum == nap);
        }

        //Adott év benzin árak listája fájlba
        public void BenzinÁrPerÉvFájlba(int év)
        {
            //List<BenzinÁr> benzinárak = new List<BenzinÁr>();
            //foreach (var item in változások)
            //{
            //    if (item.Dátum.Year == év)
            //        benzinárak.Add(new BenzinÁr(item.Dátum, item.Benzinár));
            //}
            //StreamWriter sw = new StreamWriter(év + ".txt");
            //foreach (var item in benzinárak)
            //{
            //    sw.WriteLine(item);
            //}
            //sw.Close();

            StreamWriter sw = new StreamWriter(év + ".txt");
            foreach (var item in változások.Where(v => v.Dátum.Year == év).Select(v => new BenzinÁr(v.Dátum, v.Benzinár)))
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
