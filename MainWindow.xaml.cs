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

namespace ITPSSiy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void PokupatButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new regist();
            
        }

        private void MarktButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new redactormark();
        }

        private void SotrudnikButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new redactorSotrud();
        }

        private void AutoButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new redactorAuto();
        }

        private void SalesButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content=new redactorSales();
        }
    }
}
