using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;

namespace _20220216_Papirgyujtes.Models
{
    public class Tanulo
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string osztaly { get; set; }

        public ObservableCollection<Tanulo> select()
        {
            
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tanulok";
                var result = conn.Query<Tanulo>(query);
                return new ObservableCollection<Tanulo>(result);
            }
            
        }
    }
}
