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

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool whitebg = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           
          if (this.whitebg )
          {
                cvet.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                this.whitebg = false;
                    
          }
          else 
            {
                cvet.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                this.whitebg = true;
            }
           
          


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Брюнцева Анастасия\nГруппа ИСП-32\nСпасибо за внимание!");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
           
        }
       
    }
}
