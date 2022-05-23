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

namespace _20210505_Sakktabla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SakktablaRajzol();
            UjFigura("lo",1,1);
        }

        private void SakktablaRajzol()
        {
            for (int i = 0; i < 8; i++)
            {
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
                tabla.RowDefinitions.Add(new RowDefinition());

                for (int j = 0; j < 8; j++)
                {
                    StackPanel p = new StackPanel();
                    p.Background = (i+j) % 2 == 0 ? Brushes.Black : Brushes.White;
                    tabla.Children.Add(p);
                    Grid.SetColumn(p, i);
                    Grid.SetRow(p, j);
                }
            }

        }

        private void UjFigura(string figura,int oszlop, int sor)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("Images/"+figura+".png", UriKind.Relative));
            tabla.Children.Add(img);
            Grid.SetColumn(img, oszlop);
            Grid.SetRow(img, sor);
        }
    }
}
