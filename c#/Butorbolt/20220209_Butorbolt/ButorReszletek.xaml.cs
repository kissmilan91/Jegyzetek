using _20220209_Butorbolt.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _20220209_Butorbolt
{
    /// <summary>
    /// Interaction logic for ButorReszletek.xaml
    /// </summary>
    public partial class ButorReszletek : Window
    {
        private Butor butor;
        private List<Alapanyag> alapanyagok;
        public ButorReszletek(Butor butor)
        {
            InitializeComponent();

            Alapanyag alapanyag = new Alapanyag();
            alapanyagok = alapanyag.Select();
            cbAlapanyag.ItemsSource = alapanyagok;

            this.butor = butor;
            DataContext = butor;
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            if (butor.ID == 0)
            {
                //insert kell
                butor.Create(butor);

            }
            else
            {
                //update kell
                butor.Update(butor);
            }
            DialogResult = true;
            Close();
        }

        private void btnMegesem_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
