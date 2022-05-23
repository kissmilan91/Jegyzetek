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

namespace UserBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User myUser = new User() { FirstName = "Kovács", LastName = "Béla", BirthDate = DateTime.Parse("1999.12.12") };
        public MainWindow()
        {
            InitializeComponent();
            gbUser.DataContext = myUser;
        }
    }
}
