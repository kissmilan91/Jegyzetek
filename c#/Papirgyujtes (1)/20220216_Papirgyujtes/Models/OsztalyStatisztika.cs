using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;

namespace _20220216_Papirgyujtes.Models
{
    public class OsztalyStatisztika
    {
        public string nev { get; set; }
        public int tanuloOsszesMennyiseg { get; set; }
        public string osztaly { get; set; }

        public ObservableCollection<OsztalyStatisztika> select(string osztaly)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
            conn.Open();
            string query =  "SELECT tanulok.nev, sum(leadasok.mennyiseg) as tanuloOsszesMennyiseg, tanulok.osztaly " +
                            "FROM `tanulok` LEFT JOIN `leadasok` ON `tanulok`.`id` = `leadasok`.`tanulo_id` " +
                            "WHERE tanulok.osztaly like @osztaly " +
                            "GROUP BY tanulok.id " +
                            "ORDER BY tanulok.nev;";
            var parameters = new { osztaly = osztaly };
            var result = conn.Query<OsztalyStatisztika>(query, parameters);
            conn.Close();

            return new ObservableCollection<OsztalyStatisztika>(result);
        }
    }
}
