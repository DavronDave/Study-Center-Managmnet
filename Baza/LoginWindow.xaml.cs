using baza.Datalayer;
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
using System.Windows.Shapes;

namespace baza
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }

        StudyCenterDbContext dbContext;
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
            var user = dbContext.Logins.FirstOrDefault(u => u.Username == usernameTxb.Text);
            if (user != null)
            {
                if (user.Password == passwordTxb.Password)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Error username or password");
            }
            else
                MessageBox.Show("Not found user");
          
            
        }
    }
}
