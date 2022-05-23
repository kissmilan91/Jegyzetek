using _20220323_RealEstate.Models;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RealEstateGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Seller> sellers;
        Seller seller;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string cs = "server=127.0.0.1;uid=root;pwd=;database=14ke_ingatlan";
            using (var conn = new MySqlConnection(cs))
            {
                conn.Open();
                string sql = "SELECT * FROM sellers";
                sellers = conn.Query<Seller>(sql).ToList();
                conn.Close();
            }
            lbSellers.ItemsSource = sellers;
            lbSellers.DisplayMemberPath = "Name";
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            string cs = "server=127.0.0.1;uid=root;pwd=;database=14ke_ingatlan";
            using (var conn = new MySqlConnection(cs))
            {
                conn.Open();
                string sql = "SELECT count(*) FROM realestates WHERE sellerid = @sellerId";
                int count = conn.ExecuteScalar<int>(sql, new { sellerId = (lbSellers.SelectedItem as Seller).Id });
                lblAdsCount.Content = count.ToString();
                
                conn.Close();
            }
        }

        //private void lbSellers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (lbSellers.SelectedItem == null) return;

        //    spdetails.DataContext = lbSellers.SelectedItem as Seller;
        //}
    }
}
