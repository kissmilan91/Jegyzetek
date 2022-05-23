using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class Program
    {
        static List<Forduló> fordulók = new List<Forduló>();
        static void Main(string[] args)
        {
            foreach (var sor in File.ReadAllLines("toto.txt").Skip(1))
            {
                fordulók.Add(new Forduló(sor));
            }
            Console.WriteLine("Fordulók száma: {0}",fordulók.Count);

            Console.WriteLine("Telitalálatos szelvények száma: {0}",TeliTalálatDb());

            Console.WriteLine("Átlag: {0} Ft",Math.Round(Átlag()));


            int max = MaxNyeremény();
            Console.WriteLine("A legnagyobb nyeremény:");
            Console.WriteLine("\tÉv: {0} Ft",fordulók[max].Év);
            Console.WriteLine("\tHét: {0} Ft",fordulók[max].Hét);
            Console.WriteLine("\tÖsszege: {0} Ft", fordulók[max].Ny13p1);

            if (VolteDöntetlenNélküliForduló())
                Console.WriteLine("Volt döntetlen nélküli forduló.");
            else
                Console.WriteLine("Nem volt döntetlen nélküli forduló.");


            Console.ReadKey();
        }

        static bool VolteDöntetlenNélküliForduló()
        {
            foreach (var item in fordulók)
            {
                EredmenyElemzo ee = new EredmenyElemzo(item.Eredmények);
                if (ee.NemvoltDontetlenMerkozes)
                    return true;
            }
            return false;
        }

        static int TeliTalálatDb()
        {
            int teliTalálatDb = 0;
            foreach (var item in fordulók)
            {
                teliTalálatDb += item.T13p1;
            }
            return teliTalálatDb;
        }

        static double Átlag()
        {
            double összeg = 0;
            int db = 0;
            foreach (var item in fordulók)
            {
                if (item.T13p1 > 0)
                {
                    összeg += item.T13p1 * item.Ny13p1;
                    db++;
                }
            }
            return összeg / db;
        }

        static int MaxNyeremény()
        {
            int maxIndex = 0;
            for (int i = 1; i < fordulók.Count; i++)
            {
                if (fordulók[i].Ny13p1 > fordulók[maxIndex].Ny13p1)
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
