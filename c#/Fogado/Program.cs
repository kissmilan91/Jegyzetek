using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210324_Fogado
{
    class Program
    {
        static List<Foglalás> foglalások = new List<Foglalás>();
        static void Main(string[] args)
        {
            FájlBeolvas("fogado.txt");
            Console.WriteLine("Foglalások száma: {0}",foglalások.Count);
            Console.Write("Tanár neve: ");
            string tanárneve = Console.ReadLine();
            int foglalásokSzáma = FoglalásokSzáma(tanárneve);
            if (foglalásokSzáma == 0)
                Console.WriteLine("A megadott néven nics foglalás.");
            else
                Console.WriteLine("{0} néven {1} időpint foglalás van.",tanárneve,foglalásokSzáma);

            Console.Write("Időpont (pl: 17:10): ");
            string időpont = Console.ReadLine();
            Console.WriteLine("Foglalt tanárok az adott idpontban:");
            foreach (var item in FoglaltTanárok(időpont))
            {
                Console.WriteLine("\t{0}",item);
            }
            File.WriteAllLines(időpont.Replace(":","")+".txt", FoglaltTanárok(időpont));


            List<string> szabadIdőpontok = new List<string>();
            for (int óra = 16; óra < 18; óra++)
            {
                for (int perc = 0; perc <= 50; perc+=10)
                {
                    szabadIdőpontok.Add(óra.ToString() + ":" + perc.ToString().PadLeft(2, '0')); 

                }
            }
            foreach (var item in foglalások)
            {
                if (item.TeljesNév == "Barna Eszter")
                    szabadIdőpontok.Remove(item.IdőpontString);
            }

            Console.WriteLine("Barna Eszter szabad időpontjai:");
            foreach (var item in szabadIdőpontok)
            {
                Console.WriteLine("\t{0}",item);
            }

            Console.ReadKey();
        }

        static void FájlBeolvas(string fájlnév)
        {
            foreach (var item in File.ReadAllLines(fájlnév))
            {
                foglalások.Add(new Foglalás(item));
            }
        }

        static int FoglalásokSzáma(string tanárneve)
        {
            int db = 0;
            foreach (var item in foglalások)
            {
                if (item.TeljesNév == tanárneve)
                    db++;
            }
            return db;
        }

        static List<string> FoglaltTanárok(string időpont)
        {
            List<string> nevek = new List<string>();
            foreach (var item in foglalások)
            {
                if (item.IdőpontString == időpont)
                    nevek.Add(item.TeljesNév);
            }
            return nevek;
        }
    }
}
