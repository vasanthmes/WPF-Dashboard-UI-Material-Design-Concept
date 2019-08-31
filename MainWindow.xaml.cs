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

namespace MobileAppUsageDashboard
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

        private void todayBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadio.IsChecked = true;
            monthRadio.IsChecked = false;
            weekRadio.IsChecked = false;
        }

        private void weekBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadio.IsChecked = false;
            weekRadio.IsChecked = true;
            monthRadio.IsChecked = false;
        }

        private void monthBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadio.IsChecked = false;
            weekRadio.IsChecked = false;
            monthRadio.IsChecked = true;
        }

        private void dragME(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
