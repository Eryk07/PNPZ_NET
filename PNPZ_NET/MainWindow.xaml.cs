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
    /// Class MainWindow includes activators from UI and use functions from class Text to make app working properly
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()         
        {
            InitializeComponent();
        }
      
        private string line;    // line of text
     
        private string[] stringTab = { "Wczytaj","coś","ze","schowka!",":)" }; //default tab of text

        private void Button_Click_Start(object sender, RoutedEventArgs e)   //action from Start! button
        {
            var btn = sender as Button;     
            btn.IsEnabled = false;      //deactivation of button during work of method
            int it = 0;                 //iterator
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(Period.Value) };     //Period animation clock, gets milisecs from Period slider
            timer.Tick += (sender2, args) =>    
            {
                if (it >= stringTab.Length) 
                {
                    timer.Stop();       //clock stop
                    textBlock.Text = "";   //clean textblock
                    btn.IsEnabled = true; //activation of button
                }
                else
                {
                    textBlock.Text = Text.WordsAmount(stringTab, Convert.ToInt32(Count.Value), it); //fill textblock given from slider Count amount of words from tab
                    it += Convert.ToInt32(Count.Value); //next iteration
                }
            };
            timer.Start();
        }

        private void Button_Click_Clipboard(object sender, RoutedEventArgs e) //action from Wczytaj ze schowka button
        {
            line = Text.GetLineFromClipBoard(); //load line from clipboard
            stringTab  = Text.SeparatedLine(line); //separate line into tab of strings           
        }  
    }
}
