using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407_Uzemanyagarak
{
    class Program
    {
        static void Main(string[] args)
        {
            ÖsszesVáltozás övPéldány = new ÖsszesVáltozás("uzemanyag.txt");
            Console.WriteLine("Változások száma: {0}",övPéldány.VáltozásokSzáma);
            Console.WriteLine("Legkisebb különbség: {0}",övPéldány.LegkisebbKülönbség);
            Console.WriteLine("Legkisebb különbség előfordulása: {0}",övPéldány.LegkisebbKülönbségekSzáma);
            if (övPéldány.VoltVáltozásSzökőnapon)
                Console.WriteLine("Volt változás szökőnapon.");
            else
                Console.WriteLine("Nem volt változás szökőnapon.");
            if (övPéldány.VoltMagasabbBenzin(500))
                Console.WriteLine("A benzin ára volt 500Ft-nál magasabb");
            else
                Console.WriteLine("A benzin ára NEM volt 500Ft-nál magasabb.");
            Console.WriteLine("A gázolaj átlagára: {0:f2}Ft",övPéldány.ÁtlagGázolajÁr);

            Console.WriteLine("A benzin {0} alkalommal volt drágább mint a gázolaj.",övPéldány.BenzinDrágább);

            Console.WriteLine("2013.11.06-ai adatok: ");
            Változás v = övPéldány.Keresés(new DateTime(2013, 11, 6));
            if (v != null)
            {
                Console.WriteLine("\tBenzin ára: {0}",v.Benzinár);
                Console.WriteLine("\tGázolaj ára: {0}",v.Gázoljaár);
            }
            else
            {
                Console.WriteLine("\tNincs ilyen nap a nyilvántartásban.");
            }

            övPéldány.BenzinÁrPerÉvFájlba(2013);

            Console.ReadKey();
        }
    }
}
