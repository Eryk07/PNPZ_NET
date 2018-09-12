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
        private int _index = -1;
        private string[] tab = new string[] { "Dupa", "fiut", "co Kurwa", "jasne", "zjeb", "debil" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //_index++;
            //if (_index >= tab.Length)
            //    _index = 0;

            //textBlock.Text = tab[_index];
            var btn = sender as Button;
            btn.IsEnabled = false;
            int it = 0;
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(100) };
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

    }
}
