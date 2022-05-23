using Newtonsoft.Json;
using System;
using System.IO;

namespace _20220316_PeopleJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("people.json");
            var peopleRoot = JsonConvert.DeserializeObject<People>(json);
            foreach (var item in peopleRoot.people)
            {
                Console.WriteLine("{0} - {1}",item.name, item.country);
            }
        }
    }
}
