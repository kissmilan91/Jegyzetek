using System;
using System.Collections.Generic;
using System.IO;
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

namespace _20211208_Autok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autok = new List<Auto>();
        public string fajlnev = "autok.txt";
        private string allapot;

        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
            lbAutok.ItemsSource = autok;
            //lbAutok.Items.Refresh();
            ReszletekSzerkesztese(false);
        }

        private void Beolvas()
        {
            string[] sorok = File.ReadAllLines(fajlnev);
            //Suzuki Swift;2008;4;Kek
            foreach (var sor in sorok)
            {
                //string[] adatok = sor.Split(';');
                //Auto auto = new Auto() { Tipus = adatok[0], Evjarat = int.Parse(adatok[1]), AjtokSzama = int.Parse(adatok[2]), Szin = adatok[3] };

                //auto.Tipus = adatok[0];
                //auto.Evjarat = int.Parse(adatok[1]);
                //auto.AjtokSzama = int.Parse(adatok[2]);
                //auto.Szin = adatok[3];

                //Auto auto = new Auto(sor);
                //autok.Add(auto);

                autok.Add(new Auto(sor));
            }
        }

        private void lbAutok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbAutok.SelectedIndex != -1)
            {
                Auto kivalasztott = lbAutok.SelectedItem as Auto;
                tbTipus.Text = kivalasztott.Tipus;
                tbEvjarat.Text = kivalasztott.Evjarat.ToString();
                tbAjtokSzama.Text = kivalasztott.AjtokSzama.ToString();
                tbSzin.Text = kivalasztott.Szin;
            }
            else
            {
                ReszletekKiurit();
            }
        }

        private void ReszletekKiurit()
        {
            tbTipus.Text = "";
            tbEvjarat.Text = "";
            tbSzin.Text = "";
            tbAjtokSzama.Text = "";
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbAutok.SelectedIndex != -1)
            {

                if (MessageBox.Show($"Biztos, hogy törölni szertené az alábbi autót: {(lbAutok.SelectedItem as Auto).Tipus}?",
                                    "Törlés megerősítése",MessageBoxButton.YesNoCancel,MessageBoxImage.Question) 
                    == MessageBoxResult.Yes)
                {
                    autok.RemoveAt(lbAutok.SelectedIndex);
                    lbAutok.Items.Refresh();
                }

            }
        }

        private void ReszletekSzerkesztese(bool enged)
        {
            tbAjtokSzama.IsEnabled = enged;
            tbEvjarat.IsEnabled = enged;
            tbSzin.IsEnabled = enged;
            tbTipus.IsEnabled = enged;
            btnMentes.IsEnabled = enged;
            btnMegsem.IsEnabled = enged;
        }

        private void MuveletekEngedelyezese(bool enged)
        {
            lbAutok.IsEnabled = enged;
            btnModosit.IsEnabled = enged;
            btnTorol.IsEnabled = enged;
            btnUjAuto.IsEnabled = enged;
        }

        private void btnModosit_Click(object sender, RoutedEventArgs e)
        {
            ReszletekSzerkesztese(true);
            MuveletekEngedelyezese(false);
            allapot = "modosit";
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            switch (allapot)
            {
                case "modosit":
                    autok[lbAutok.SelectedIndex].Tipus = tbTipus.Text;
                    autok[lbAutok.SelectedIndex].Evjarat = int.Parse(tbEvjarat.Text);
                    autok[lbAutok.SelectedIndex].AjtokSzama = int.Parse(tbAjtokSzama.Text);
                    autok[lbAutok.SelectedIndex].Szin = tbSzin.Text;
                    lbAutok.Items.Refresh();
                    break;
                case "uj":
                    Auto auto = new Auto(tbTipus.Text, int.Parse(tbEvjarat.Text), int.Parse(tbAjtokSzama.Text), tbSzin.Text);
                    autok.Add(auto);
                    lbAutok.Items.Refresh();
                    break;
            }

            allapot = "";
            ReszletekSzerkesztese(false);
            MuveletekEngedelyezese(true);
        }

        private void btnUjAuto_Click(object sender, RoutedEventArgs e)
        {
            allapot = "uj";
            ReszletekSzerkesztese(true);
            MuveletekEngedelyezese(false);
            ReszletekKiurit();
        }

        private void btnMegsem_Click(object sender, RoutedEventArgs e)
        {
            switch (allapot)
            {
                case "uj":
                    ReszletekKiurit();
                    break;
                case "modosit":
                    lbAutok_SelectionChanged(sender, null);
                    break;
            }
            allapot = "";
            ReszletekSzerkesztese(false);
            MuveletekEngedelyezese(true);
        }
    }
}
