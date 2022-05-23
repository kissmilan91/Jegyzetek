using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;

namespace _20220216_Papirgyujtes.Models
{
    class Leadas
    {
        public int id { get; set; }
        public int tanulo_id { get; set; }
        public int mennyiseg { get; set; }
        public DateTime idopont { get; set; }

        public ObservableCollection<Leadas> select(int tanulo_id)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM leadasok WHERE tanulo_id = @tanuloid;";
                var parameters = new { tanuloid = tanulo_id };
                var result = conn.Query<Leadas>(query, parameters);
                return new ObservableCollection<Leadas>(result);
            }
        }

        public int create(Leadas leadas)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO `leadasok`(`tanulo_id`, `idopont`, `mennyiseg`) VALUES (@tanuloid, @idopont, @mennyiseg)";
                var parameters = new { tanuloid = leadas.tanulo_id, idopont = leadas.idopont, mennyiseg = leadas.mennyiseg };
                return conn.Execute(query, parameters);
            }
        }
    }
}
