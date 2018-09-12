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
using System.Windows.Threading;


namespace PNPZ_NET
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // private int _index = -1;
        //Text text = new Text();
        private string line = "Wtyczka do Windowsa umożliwiająca wyświetlanie zaznaczonego tekstu metodą szybkiego czytania - tekst z dużą prędkością jest wyświetlany po kilka słów lub w formie wężyka. Wtyczka będzie korzystać z Windows Animation Manager.";
        //Text.cut_line stringTab;
        // stringTab = Text.separated_line(line);
        private string[] tab = { "Dupa", "debil", "gamoń", "gapciok" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //_index++;
            //if (_index >= tab.Length)
            //    _index = 0;

            //textBlock.Text = tab[_index];
            var btn = sender as Button;
            btn.IsEnabled = false;
            int it = 0;
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(200) };
            timer.Tick += (sender2, args) =>
            {
                if (it == tab.Length)
                {
                    timer.Stop();
                    textBlock.Text = "";
                    btn.IsEnabled = true;
                }
                else
                {
                    textBlock.Text = tab[it++];
                }
            };
            timer.Start();
        }

        private void Button_Click_Clipboard(object sender, RoutedEventArgs e)
        {
            //tab=
        }
    }
}
