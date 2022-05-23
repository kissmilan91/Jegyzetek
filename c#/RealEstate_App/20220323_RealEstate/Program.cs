using _20220323_RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20220323_RealEstate
{
    class Program
    {
        static List<Ad> ads;
        static void Main(string[] args)
        {
            //ads = Ad.LoadFromCsv("realestates.csv");
            ads = Ad.LoadFromJSON("realestates.json");
            Console.WriteLine($"1. Földszinti ingatlanok átlagos alapterülete: {AverageArea(0):f2} m2");
            double average = ads.Where(a => a.Floors == 0).Average(a => a.Area);
            Console.WriteLine($"1. Földszinti ingatlanok átlagos alapterülete: {average:f2} m2");
            Console.WriteLine("2. A Mesevár óvodához légvonalban legközelebbi tehermentes ingatlan adatai: ");
            Ad ad = ClosestTo(47.4164220114023, 19.066342425796986);
            Console.WriteLine($"\tEladó neve     : {ad.Seller.Name}");
            Console.WriteLine($"\tEladó telefonja: {ad.Seller.Phone}");
            Console.WriteLine($"\tAlapterület    : {ad.Area}");
            Console.WriteLine($"\tSzobák száma   : {ad.Rooms}");


        }

        static double AverageArea(int floor)
        {
            int sum = 0;
            int count = 0;
            foreach (var item in ads)
            {
                if (item.Floors == floor)
                {
                    sum += item.Area;
                    count++;
                }
            }
            return sum / (double)count;
        }

        static Ad ClosestTo(double lat, double lon)
        {
            Ad closest = null;
            foreach (var item in ads)
            {
                if (item.FreeOfCharge)
                {
                    if (closest == null) closest = item;
                    else if (item.DistanceTo(lat,lon) < closest.DistanceTo(lat,lon))
                    {
                        closest = item;
                    }
                }
            }
            return closest;
        }
    }
}
