using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace _20220209_Butorbolt.Models
{
    public class Butor
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public int Ar { get; set; }
        public string Szin { get; set; }
        public DateTime Szallitas { get; set; }
        public int Alapanyag_ID { get; set; }
        public string AlapanyagNev { get; set; }

        //CRUD (Create, Read, Update, Delete)

        public Butor()
        {
        }

        public Butor(MySqlDataReader reader)
        {
            ID = Convert.ToInt32(reader["ID"]);
            Nev = reader["Nev"].ToString();
            Ar = Convert.ToInt32(reader["Ar"]);
            Szin = reader["Szin"].ToString();
            Szallitas = Convert.ToDateTime(reader["Szallitas"]);
            Alapanyag_ID = Convert.ToInt32(reader["Alapanyag_ID"]);
            AlapanyagNev = reader["AlapanyagNev"].ToString();
        }

        public List<Butor> Select(string nev = "")
        {
            List<Butor> butorok = new List<Butor>();
            //string connectionString = "Server=localhost;Database=14ke_butorbolt;Uid=root;Pwd=;";
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT `butor`.*, `alapanyag`.`Nev` AS AlapanyagNev FROM `butor` " +
                               " INNER JOIN `alapanyag` ON `butor`.`Alapanyag_ID` = `alapanyag`.`ID` " +
                               " WHERE `butor`.Nev LIKE @nev;";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nev", "%" + nev + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            butorok.Add(new Butor(reader));
                        }
                    }
                }
                //conn.Close();
            }
            return butorok;
        }

        public void Delete(Butor butor)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM `butor` WHERE ID = @ID;";
                using (var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("ID", butor.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //public long Create(Butor butor)
        public Butor Create(Butor butor)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO `butor`(`Nev`, `Ar`, `Szin`, `Szallitas`, `Alapanyag_ID`) " +
                    "           VALUES (@Nev, @Ar, @Szin, @Szallitas, @Alapanyag_ID)";
                using (var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@Nev", butor.Nev);
                    cmd.Parameters.AddWithValue("@Ar", butor.Ar);
                    cmd.Parameters.AddWithValue("@Szin", butor.Szin);
                    cmd.Parameters.AddWithValue("@Szallitas", butor.Szallitas);
                    cmd.Parameters.AddWithValue("@Alapanyag_ID", butor.Alapanyag_ID);

                    cmd.ExecuteNonQuery();

                    //return cmd.LastInsertedId;
                    butor.ID = (int)cmd.LastInsertedId;
                    return butor;
                }
            }
        }

        public Butor Update(Butor butor)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString))
            {
                conn.Open();
                string query = "UPDATE `butor` SET `Nev` = @Nev, `Ar` = @Ar, `Szin` = @Szin, `Szallitas` = @Szallitas, `Alapanyag_ID` = @Alapanyag_ID WHERE ID = @ID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nev", butor.Nev);
                    cmd.Parameters.AddWithValue("@Ar", butor.Ar);
                    cmd.Parameters.AddWithValue("@Szin", butor.Szin);
                    cmd.Parameters.AddWithValue("@Szallitas", butor.Szallitas);
                    cmd.Parameters.AddWithValue("@Alapanyag_ID", butor.Alapanyag_ID);
                    cmd.Parameters.AddWithValue("@ID", butor.ID);

                    cmd.ExecuteNonQuery();

                    return butor;
                }
            }
        }

    }
}
