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

namespace TotoGUI
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

        private void tbEredmények_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbEredmények.Text.Length == 14)
            {
                cbHibásKarakterszám.IsChecked = false;
            }
            else
            {
                cbHibásKarakterszám.IsChecked = true;
            }
            cbHibásKarakterszám.Content = "Nem megfelelő a karakterek száma (" + tbEredmények.Text.Length + ")";
            //String.Format("Nem megfelelő a karakterek száma ({0})", tbEredmények.Text.Length);

            string rosszak = "";
            foreach (var item in tbEredmények.Text)
            {
                //if (item == '1' || item == '2' || item == 'X')
                if (!"12X".Contains(item))
                {
                    rosszak += item + ";";
                }
            }
            if (rosszak == "")
            {
                cbHelytelenek.IsChecked = false;
            }
            else
            {
                cbHelytelenek.IsChecked = true;
            }
            cbHelytelenek.Content = String.Format("Helytelen karakterek az eredményben ({0})", rosszak);

            if (cbHelytelenek.IsChecked == false && cbHibásKarakterszám.IsChecked == false)
            {
                btnMentés.IsEnabled = true;
            }
            else
            {
                btnMentés.IsEnabled = false;
            }
        }
    }
}
