using _20220216_Papirgyujtes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for PageUjLeadas.xaml
    /// </summary>
    public partial class PageUjLeadas : Page
    {
        Tanulo tanulo = new Tanulo();
        Leadas leadas = new Leadas();
        ObservableCollection<Tanulo> tanulok = new ObservableCollection<Tanulo>();
        ObservableCollection<Leadas> leadasok = new ObservableCollection<Leadas>();

        ICollectionView filteredTanulok;

        public PageUjLeadas()
        {
            InitializeComponent();

            tanulok = tanulo.select();
            cboOsztaly.ItemsSource = tanulok.Select(t => t.osztaly).Distinct();
            //cboOsztaly.SelectedIndex = 1;

            filteredTanulok = CollectionViewSource.GetDefaultView(tanulok);
            cboTanulo.ItemsSource = filteredTanulok;
            cboTanulo.DisplayMemberPath = "nev";

            dpDatum.SelectedDate = DateTime.Now;
        }

        private void cboOsztaly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredTanulok.Filter = (object o) =>
            {
                if (o != null)
                {
                    return (o as Tanulo).osztaly == cboOsztaly.SelectedItem.ToString();
                }
                return false;
            };
            filteredTanulok.SortDescriptions.Add(new SortDescription("nev", ListSortDirection.Ascending));
            cboTanulo.SelectedIndex = 0;
        }

        private void cboTanulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTanulo.SelectedItem != null)
            {
                leadasok = leadas.select(((Tanulo)cboTanulo.SelectedItem).id);
                dgMennyisegek.ItemsSource = leadasok;
            }
        }

        private void btnLead_Click(object sender, RoutedEventArgs e)
        {
            if (cboTanulo.SelectedItem != null)
            {
                int mennyiseg;
                if (!String.IsNullOrWhiteSpace(tbMennyiseg.Text) &&
                    int.TryParse(tbMennyiseg.Text, out mennyiseg))
                {
                    leadas.mennyiseg = mennyiseg;
                    leadas.tanulo_id = (cboTanulo.SelectedItem as Tanulo).id;
                    leadas.idopont = (DateTime)dpDatum.SelectedDate;

                    leadas.create(leadas);
                    leadasok = leadas.select(((Tanulo)cboTanulo.SelectedItem).id);
                    dgMennyisegek.ItemsSource = leadasok;
                }
            }
        }
    }
}
