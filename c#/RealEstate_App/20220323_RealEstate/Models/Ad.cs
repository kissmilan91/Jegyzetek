using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220323_RealEstate.Models
{
    public class Ad
    {
        public int Rooms { get; set; }
        public string Latlong { get; set; }
        public int Floors { get; set; }
        public int Area { get; set; }
        public string Description { get; set; }
        public bool FreeOfCharge { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public Seller Seller { get; set; }
        public Category Category { get; set; }
        public double Lat
        {
            get
            {
                string temp = Latlong.Split(',')[0].Replace(".",",");
                return double.Parse(temp);
            }
        }
        public double Long
        {
            get
            {
                return double.Parse(Latlong.Split(',')[1].Replace(".",","));
            }
        }

        public Ad()
        {

        }
        public Ad(string row)
        {
            //rooms;latlong;floors;area;description;freeofcharge;imageUrl;sellername;sellerphone;categoryname;createat
            var splitted = row.Split(';');
            Rooms = int.Parse(splitted[0]);
            Latlong = splitted[1];
            Floors = int.Parse(splitted[2]);
            Area = int.Parse(splitted[3]);
            Description = splitted[4];
            FreeOfCharge = splitted[5] == "0" ? false : true;
            ImageUrl = splitted[6];
            Seller = new Seller() { Name = splitted[7], Phone = splitted[8] };
            Category = new Category() { Name = splitted[9] };
            CreatedAt = DateTime.Parse(splitted[10]);
        }

        public static List<Ad> LoadFromCsv(string filename)
        {
            List<Ad> ads = new List<Ad>();
            foreach (var row in File.ReadLines(filename).Skip(1))
            {
                ads.Add(new Ad(row));
            }
            return ads;
        }

        public static List<Ad> LoadFromJSON(string filename)
        {
            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<List<Ad>>(json);
        }

        public double DistanceTo(double lat, double lon)
        {
            var a = Lat - lat;
            var b = Long - lon;
            return Math.Sqrt(a * a + b * b);
        }
    }
}
