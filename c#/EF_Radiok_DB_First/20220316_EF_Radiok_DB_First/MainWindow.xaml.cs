using _20220316_EF_Radiok_DB_First.Models;
using Microsoft.EntityFrameworkCore;
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

namespace _20220316_EF_Radiok_DB_First
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        radioadokContext context = new radioadokContext();
        public MainWindow()
        {
            InitializeComponent();

            context.Regios.Load();
            context.Kiosztas.Load();
            context.Telepules.Load();

            var regiok = context.Regios.Local.OrderBy(r => r.Nev).Select(r => r.Nev).Distinct().ToList();
            cboRegio.ItemsSource = regiok;

            var teljKategoriak = context.Kiosztas.Local.Select(k => k.TeljesitmenyKategoria).Distinct().ToList();
            cboTeljesitmeny.ItemsSource = teljKategoriak;
        }

        private void cboRegio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var megyek = context.Regios.Local.Where(r => r.Nev == cboRegio.SelectedItem.ToString());
            var telepulesek = context.Telepules.Local.Where(t => megyek.Any(m => m.Megye == t.Megye))
                                                     .Select(t => t.Nev).ToList();
            cboTelepules.ItemsSource = telepulesek;
        }

        private void cboTelepules_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTelepules.SelectedItem == null) return;

            var radiok = context.Kiosztas.Where(k => k.Adohely == cboTelepules.SelectedItem.ToString()).ToList();
            dgTelepulesRadioadok.ItemsSource = radiok;
        }

        private void cboTeljesitmeny_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboTeljesitmeny.SelectedItem == null) return;

            var teljesitmenyLista = context.Kiosztas.Local.Where(k => k.TeljesitmenyKategoria == cboTeljesitmeny.SelectedItem.ToString()).ToList();
            dgTeljesitmenyRadioadok.ItemsSource = teljesitmenyLista;
        }
    }
}
