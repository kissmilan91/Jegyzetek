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
    /// Interaction logic for PageIskolaStatisztika.xaml
    /// </summary>
    public partial class PageIskolaStatisztika : Page
    {
        IskolaStatisztika iskolaStatisztika = new IskolaStatisztika();
        ObservableCollection<IskolaStatisztika> statisztikak = new ObservableCollection<IskolaStatisztika>();
        public PageIskolaStatisztika()
        {
            InitializeComponent();

            statisztikak = iskolaStatisztika.select();
            dgStatisztika.ItemsSource = statisztikak;
            tblOsszeg.Text = "Összesen: " + (statisztikak.Sum(s => s.osszes) / 100.0).ToString() + " kg.";
        }
    }
}
