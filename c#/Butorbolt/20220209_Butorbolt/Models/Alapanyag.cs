using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace _20220209_Butorbolt.Models
{
    public class Alapanyag
    {
        public int ID { get; set; }
        public string Nev { get; set; }

        public Alapanyag()
        {

        }

        public Alapanyag(MySqlDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"]);
            Nev = reader["Nev"].ToString();
        }

        public List<Alapanyag> Select()
        {
            List<Alapanyag> alapanyagok = new List<Alapanyag>();

            using(var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM `alapanyag` ORDER BY Nev";
                using (var cmd = new MySqlCommand(query,conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alapanyagok.Add(new Alapanyag(reader));
                        }
                    }
                }
            }

            return alapanyagok;
        }
    }
}
