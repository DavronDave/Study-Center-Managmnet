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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace baza.ListPages
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        MainWindow main;
        public SettingsControl(MainWindow owner)
        {
            InitializeComponent();
            main = owner;
        }
      
        private void changeAccBtn_Click(object sender, RoutedEventArgs e)
        {
            main.CenternameTxb.Text= changeCenterTXB.Text;
            changeCenterTXB.Text = "";
        }
        private void changeNameBtn_Click(object sender, RoutedEventArgs e)
        {
            main.accountNametxb.Text = changenameTXB.Text;
            changenameTXB.Text = "";
        }
        StudyCenterDbContext dbContext;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
            var num = dbContext.Students.Select(x => x).Count();
            numberstudents.Text = num.ToString();

            var numflayer = dbContext.Students.Where(x => x.Survey == "Flayer").Count();
            numberstudentflayer.Text = numflayer.ToString();

            var numsocial = dbContext.Students.Where(x => x.Survey == "Social Network").Count();
            numberstudentsocial.Text = numsocial.ToString();

            var numfriend = dbContext.Students.Where(x => x.Survey == "Friend").Count();
            numberstudentfriend.Text = numfriend.ToString();

            var numteach = dbContext.Teachers.Select(x => x).Count();
            numberteacher.Text = numteach.ToString();


            var yulduz = dbContext.Students.Where(x => x.Moderator == "Yulduz Ikromova").Count();
            moderatoryulduz.Text = yulduz.ToString();

            var sitora = dbContext.Students.Where(x => x.Moderator == "Sitora Akbarova").Count();
            moderatorsitora.Text = sitora.ToString();
        }
    }
}
