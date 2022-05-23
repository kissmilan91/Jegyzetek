using _20220209_Butorbolt.Models;
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

namespace _20220209_Butorbolt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Butor> butorok = new List<Butor>();
        Butor butor = new Butor();
        public MainWindow()
        {
            InitializeComponent();
            UpdateDataGrid();
            
        }

        private void btnKeres_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbNevKereso.Text))
            {
                butorok = butor.Select(tbNevKereso.Text);
            }
            else
            {
                butorok = butor.Select();
            }
            dgButorok.ItemsSource = butorok;
        }

        private void btnButorTorol_Click(object sender, RoutedEventArgs e)
        {
            if (dgButorok.SelectedItem != null && MessageBox.Show("Valóban törölni akarja a kijelölt bútort?","Törlés",MessageBoxButton.YesNoCancel,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                butor = dgButorok.SelectedItem as Butor;
                butor.Delete(butor);
                UpdateDataGrid();
            }
        }

        private void btnUjButor_Click(object sender, RoutedEventArgs e)
        {
            butor = new Butor();
            butor.ID = 0; //ha 0 az ID akkor a Bútor részletek ablakban Insert kell
            ButorReszletek butorReszletek = new ButorReszletek(butor);
            if (butorReszletek.ShowDialog()  == true)
            {
                UpdateDataGrid();
            }
        }

        private void btnButorSzerkeszt_Click(object sender, RoutedEventArgs e)
        {
            if (dgButorok.SelectedItem != null)
            {
                butor = dgButorok.SelectedItem as Butor; //létező bútor (nem 0 az ID), a Bútor részletek ablakban majd Update kell
                ButorReszletek butorReszletek = new ButorReszletek(butor);
                if (butorReszletek.ShowDialog() == true)
                {
                    UpdateDataGrid();
                }
            }

        }

        private void UpdateDataGrid()
        {
            butorok = butor.Select();
            dgButorok.ItemsSource = butorok;
        }
    }
}
