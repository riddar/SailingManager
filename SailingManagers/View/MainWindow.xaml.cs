using SailingManagers.View;
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

namespace SailingManagers
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

        private void Båt_OnClick(object sender, RoutedEventArgs e)
        {
          BoatWindow boatWindow = new BoatWindow();
            boatWindow.Show();

        }

        private void Teams_OnClick(object sender, RoutedEventArgs e)
        {
            TeamWindow teamWindow = new TeamWindow();
            teamWindow.Show();
        }

        private void Regattor_OnClick(object sender, RoutedEventArgs e)
        {
            RegattasWindow regattasWindow = new View.RegattasWindow();
            regattasWindow.Show();
        }

        private void Users_OnClick(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow();
            userWindow.Show();
        }

        private void Events_OnClick(object sender, RoutedEventArgs e)
        {
            EventsWindow eventWindow = new EventsWindow();
            eventWindow.Show();
        }

        private void Båtklubb_OnClick(object sender, RoutedEventArgs e)
        {
            BoatClubWindow boatClubWindow = new BoatClubWindow();
            boatClubWindow.Show();
        }

        private void Register_OnClick(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new View.RegisterWindow();
            registerWindow.Show();
        }

        private void Entrypage_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void RegattaPage_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            RegattaUserControl regattaUserControl = new RegattaUserControl();
            
        }
    }
}
