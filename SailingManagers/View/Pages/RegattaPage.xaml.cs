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
using SailingManagers;

namespace SailingManagers.View
{
    /// <summary>
    /// Interaction logic for RegattaPage.xaml
    /// </summary>
   
    public partial class RegattaPage : Page
    {
        private MainWindow mainwindow;
        public RegattaPage()
        {
            InitializeComponent();
        }

        private void GoBack_OnClick(object sender, RoutedEventArgs e)
        {
            if (mainwindow == null)
            {
                mainwindow = new MainWindow();
            }

            mainwindow.ShowDialog();



        }
    }
}
