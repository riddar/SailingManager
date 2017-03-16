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
        EntryPage entryPage = new EntryPage();
        RegattaPage regattaPage = new RegattaPage();
        private CreateBoatClubPage createBoatClubPage = new CreateBoatClubPage();
        private CreateBoatPage createBoatPage = new CreateBoatPage();
        private CreateEventPage createEventPage = new CreateEventPage();
        private CreateRegattaPage createRegattaPage = new CreateRegattaPage();
        private CreateTeamPage createTeamPage = new CreateTeamPage();
        private CreateUserPage createUserPage = new CreateUserPage();
        private RegisterPage registerPage = new RegisterPage();
        public MainWindow()
        {
            InitializeComponent();
            MainWindowFrame.Navigate(regattaPage);

        }

        private void Båt_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createBoatPage);

        }

        private void Teams_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createTeamPage);
        }

        private void Regattor_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createRegattaPage);
        }

        private void Users_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createUserPage);
        }

        private void Events_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createEventPage);
        }

        private void Båtklubb_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(createBoatClubPage);
        }

        private void Register_OnClick(object sender, RoutedEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(registerPage);
        }

        private void Entrypage_DoubleClick(object sender, MouseButtonEventArgs e)
        {

            ClearHistory();
           MainWindowFrame.Navigate(entryPage);
            
        }

        private void RegattaPage_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            ClearHistory();
            MainWindowFrame.Navigate(regattaPage);
           

        }
        public void ClearHistory()
        {
            if (!this.MainWindowFrame.CanGoBack && !this.MainWindowFrame.CanGoForward)
            {
                return;
            }

            var entry = this.MainWindowFrame.RemoveBackEntry();
            while (entry != null)
            {
                entry = this.MainWindowFrame.RemoveBackEntry();
            }

            this.MainWindowFrame.Navigate(new PageFunction<string>() { RemoveFromJournal = true });
        }

    }
}
