using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210324_footgolf
{
    class Program
    {
        static List<Versenyző> versenyzők = new List<Versenyző>();
        static void Main(string[] args)
        {
            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                versenyzők.Add(new Versenyző(sor));
            }

            Console.WriteLine("Versenyzők száma: {0}",versenyzők.Count);
            Console.WriteLine("Női versenyzők aránya: {0:f2}%", (double)VersenyzőkSzáma("Noi") / versenyzők.Count * 100);
            Console.WriteLine("Férfi versenyzők aránya: {0:f2}%", (double)VersenyzőkSzáma("Felnott ferfi") / versenyzők.Count * 100);
            Console.WriteLine("A női kategória győztese");
            //int nőigyőztes = Győztes("Noi");
            //Console.WriteLine("\tNév:{0}",versenyzők[nőigyőztes].Név);
            //Console.WriteLine("\tEgyesület:{0}",versenyzők[nőigyőztes].Egyesület);
            //Console.WriteLine("\tÖsszpontszáma:{0}",versenyzők[nőigyőztes].Összpontszám);
            Versenyző nőigyőztes = Győztes("Noi");
            Console.WriteLine("\tNév:{0}", nőigyőztes.Név);
            Console.WriteLine("\tEgyesület:{0}", nőigyőztes.Egyesület);
            Console.WriteLine("\tÖsszpontszáma:{0}", nőigyőztes.Összpontszám);

            AdatokFájlba("Felnott ferfi", "osszpontFF.txt");

            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in versenyzők)
            {
                if (stat.ContainsKey(item.Egyesület))
                    stat[item.Egyesület]++;
                else
                    stat.Add(item.Egyesület, 1);
            }
            Console.WriteLine("Egyesület statisztika");
            foreach (var item in stat)
            {
                if (item.Key != "n.a." && item.Value > 2)
                Console.WriteLine("\t{0} - {1}fő",item.Key,item.Value);
            }

            Console.ReadKey();
             
        }

        static int VersenyzőkSzáma(string kategória)
        {
            int db = 0;
            foreach (var item in versenyzők)
            {
                if (item.Kategória == kategória)
                    db++;
            }
            return db;
        }
        //static int Győztes(string kategória)
        //{
        //    int győztes = -1;  //győztes versenyző indexe
        //    for (int i = 0; i < versenyzők.Count; i++)
        //    {
        //        if (versenyzők[i].Kategória == kategória)
        //        {
        //            if (győztes == -1 || versenyzők[i].Összpontszám > versenyzők[győztes].Összpontszám)
        //            {
        //                győztes = i;
        //            }
        //        }
        //    }
        //    return győztes;
        //}

        static Versenyző Győztes(string kategória)
        {
            Versenyző győztes = null;  //győztes versenyző
            foreach (var item in versenyzők)
            {
                if (item.Kategória == kategória)
                {
                    if (győztes == null || item.Összpontszám > győztes.Összpontszám)
                    {
                        győztes = item;
                    }
                }
            }
            return győztes;
        }

        static void AdatokFájlba(string kategóra, string fájlnév)
        {
            StreamWriter sw = new StreamWriter(fájlnév);
            foreach (var item in versenyzők)
            {
                if (item.Kategória == kategóra)
                {
                    sw.WriteLine("{0};{1}", item.Név, item.Összpontszám);
                }
            }
            sw.Close();
        }
    }
}
