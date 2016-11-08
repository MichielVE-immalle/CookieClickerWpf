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

namespace CoockieClickerWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Coockie_MouseEnter(object sender, MouseEventArgs e)
        {
            Coockie.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Coockie.StrokeThickness = 4;
            Coockie.Stroke = new SolidColorBrush(Colors.Black);
        }

        private void Coockie_MouseLeave(object sender, MouseEventArgs e)
        {
            Coockie.Fill = new SolidColorBrush(Colors.Gray);
            Coockie.StrokeThickness = 2;
            Coockie.Stroke = new SolidColorBrush(Colors.Black);
        }

        private void Coockie_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (getal < 500)
            {
                getal = getal + 1;
                teller.Text = String.Format("{0}", getal);
                hoeveel.Text = "1 Koekje per klik";
            }

            if (getal >= 500)
            {
                getal = getal + 4;
                teller.Text = String.Format("{0}", getal);
                hoeveel.Text = "4 Koekjes per klik";
            }
        }
    }
}
