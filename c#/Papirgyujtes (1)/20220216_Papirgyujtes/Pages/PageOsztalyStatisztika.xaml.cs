using _20220216_Papirgyujtes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20220216_Papirgyujtes.Pages
{
    /// <summary>
    /// Interaction logic for PageOsztalyStatisztika.xaml
    /// </summary>
    public partial class PageOsztalyStatisztika : Page
    {
        OsztalyStatisztika osztalyStatisztika = new OsztalyStatisztika();
        ObservableCollection<OsztalyStatisztika> statisztikak = new ObservableCollection<OsztalyStatisztika>();
        Tanulo tanulo = new Tanulo();
        ObservableCollection<Tanulo> tanulok = new ObservableCollection<Tanulo>();
        public PageOsztalyStatisztika()
        {
            InitializeComponent();

            tanulok = tanulo.select();
            cboOsztaly.ItemsSource = tanulok.Select(t => t.osztaly).Distinct();
            cboOsztaly.SelectedIndex = 0;

            Frissites();
        }

        private void cboOsztaly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frissites();
        }

        private void Frissites()
        {
            statisztikak = osztalyStatisztika.select(cboOsztaly.SelectedItem.ToString());
            dgStatisztika.ItemsSource = statisztikak;
            tblOsszeg.Text = "Összesen: " + (statisztikak.Sum(s => s.tanuloOsszesMennyiseg) / 100.0).ToString() + "kg";
        }
    }
}
