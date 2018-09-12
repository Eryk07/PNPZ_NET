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
        private string[]  tab = new string[]{ "Dupa","fiut","co Kurwa","jasne","zjeb","debil" };

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //_index++;
            //if (_index >= tab.Length)
            //    _index = 0;

            //textBlock.Text = tab[_index];

            for (int i = 0; i < tab.Length; i++)
            {
                textBlock.Text = tab[i];
                System.Threading.Thread.Sleep(100);
            }
        }

    }
}
