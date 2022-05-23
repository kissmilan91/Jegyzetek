using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;

namespace _20220216_Papirgyujtes.Models
{
    public class IskolaStatisztika
    {
        public string osztaly { get; set; }
        public int osszes { get; set; }
        public int legkevesebb { get; set; }
        public int legtobb { get; set; }
        public int darab { get; set; }

        public ObservableCollection<IskolaStatisztika> select()
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
            conn.Open();
            string query =  "SELECT tanulok.osztaly, " +
                                "sum(leadasok.mennyiseg) as osszes, " +
                                "min(leadasok.mennyiseg) as legkevesebb, " +
                                "max(leadasok.mennyiseg) as legtobb, " +
                                "COUNT(*) as darab " +
                            "FROM `tanulok` LEFT JOIN `leadasok` ON `tanulok`.`id` = `leadasok`.`tanulo_id` " +
                            "GROUP BY tanulok.osztaly " +
                            "ORDER BY osszes DESC;";
            var result = conn.Query<IskolaStatisztika>(query);
            conn.Close();
            return new ObservableCollection<IskolaStatisztika>(result);
        }

    }
}
