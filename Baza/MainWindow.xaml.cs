using baza.Datalayer;
using baza.ListPages;
using baza.Models;
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

namespace baza
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

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            GridMain.Opacity = 1;
            GridMain.IsEnabled = true;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridMain.Opacity = 0.5;
            GridMain.IsEnabled = false;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;

            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Teacher":
                    usc = new TeacherControl();
                    GridMain.Children.Add(usc);
                    break;
                case "Student":
                    usc = new StudentControl();
                    GridMain.Children.Add(usc);
                    break;
                case "Group":
                    usc = new GroupControl();
                    GridMain.Children.Add(usc);
                    break;
                case "Setting":
                    usc = new SettingsControl(this);
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            usc = new SettingsControl(this);
            GridMain.Children.Add(usc);
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to Log out?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                this.Close();
            }
                
        }
    }
}
