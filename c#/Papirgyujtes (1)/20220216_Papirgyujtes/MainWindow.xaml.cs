using _20220216_Papirgyujtes.Pages;
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

namespace _20220216_Papirgyujtes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miOsztalyStat_Click(object sender, RoutedEventArgs e)
        {
            PageOsztalyStatisztika pageOsztalyStatisztika = new PageOsztalyStatisztika();
            frmContainer.Content = pageOsztalyStatisztika;
        }

        private void miUjLeadas_Click(object sender, RoutedEventArgs e)
        {
            PageUjLeadas pageUjLeadas = new PageUjLeadas();
            frmContainer.Content = pageUjLeadas;
        }

        private void miIskolaStat_Click(object sender, RoutedEventArgs e)
        {
            PageIskolaStatisztika pageIskolaStatisztika = new PageIskolaStatisztika();
            frmContainer.Content = pageIskolaStatisztika;
        }
    }
}
