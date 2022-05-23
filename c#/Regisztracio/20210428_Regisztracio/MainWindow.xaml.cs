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

namespace _20210428_Regisztracio
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

        private void btnRegisztrál_Click(object sender, RoutedEventArgs e)
        {
            if (tbNév.Text != "")
            {
                if (pbJelszó.Password != "")
                {
                    if (dpSzuletes.SelectedDate != null)
                    {
                        if (rbFerfi.IsChecked == true || rbNo.IsChecked == true)
                        {
                            StreamWriter sw = new StreamWriter("users.txt",true);
                            sw.WriteLine(String.Format("{0};{1};{2};{3}",
                                tbNév.Text, pbJelszó.Password, DateTime.Parse(dpSzuletes.SelectedDate.ToString()).ToShortDateString(),
                                rbFerfi.IsChecked == true ? "férfi" : "nő"));
                            sw.Close();
                        }
                        else
                        {
                            rbFerfi.Focus();
                        }
                    }
                    else
                    {
                        dpSzuletes.Focus();
                    }
                }
                else
                {
                    pbJelszó.Focus();
                }
            }
            else
            {
                tbNév.Focus();
            }
        }
    }
}
