using baza.Datalayer;
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

namespace baza.ListPages
{
    /// <summary>
    /// Interaction logic for StudentControl.xaml
    /// </summary>
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        StudyCenterDbContext dbContext;
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
            Student student = new Student();
            if(fnameTxt.Text!="" && lnameTxt.Text!="" && phoneTxt.Text!="" && moderatorCmb.Text != "")
            {
                student.Fname = fnameTxt.Text;
                student.Lname = lnameTxt.Text;
                student.Phone = phoneTxt.Text;
                student.Survey = survetCmb.Text;
                student.DateBirth = datepicker.SelectedDate;
                student.Moderator = moderatorCmb.Text;
                
                dbContext.Students.Add(student);
                dbContext.SaveChanges();
                StudentDatagrid.ItemsSource = dbContext.Students.OrderByDescending(x => x.StudentId).ToList();
                fnameTxt.Text = "";
                lnameTxt.Text = "";
                phoneTxt.Text = "";
                survetCmb.Text = "";
                datepicker.SelectedDate = default;
                moderatorCmb.Text = "";
            }
            else
            MessageBox.Show("Please insert all data");
           
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
            StudentDatagrid.ItemsSource = dbContext.Students.OrderByDescending(x => x.StudentId).ToList();
            //GroupCombo.ItemsSource = dbContext.Groups.ToList();
        }

        private void StudentDatagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
            //e.Row.Header = (e.Row.GetIndex()).ToString();
        }

        public Student Student = new Student();
        private void updateCellBtn_Click(object sender, RoutedEventArgs e)
        {
            Student = (sender as FrameworkElement).DataContext as Student;
            studentGrid.DataContext = Student;
            InsertBtn.IsEnabled = false;

            var idG = (StudentDatagrid.SelectedItem as Student).StudentId;
            var query = from article in dbContext.Groups
                        where article.Students.Any(c => c.StudentId == idG)
                        select article.Name;

  
            groupsLbx.ItemsSource = query.ToList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var studentId = (StudentDatagrid.SelectedItem as Student).StudentId;
                var studentToBeDeleted = dbContext.Students.Where(x => x.StudentId == studentId).SingleOrDefault();

                dbContext.Students.Remove(studentToBeDeleted);
                dbContext.SaveChanges();
                //GetProducts();
                StudentDatagrid.ItemsSource = dbContext.Students.ToList();
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (fnameTxt.Text != "" && lnameTxt.Text != "")
            {
                Student.Fname = fnameTxt.Text;
                Student.Lname = lnameTxt.Text;
                Student.Phone = phoneTxt.Text;
                Student.Survey = survetCmb.Text;
                Student.DateBirth = datepicker.SelectedDate;
                Student.Moderator = moderatorCmb.Text;
                dbContext.Update(Student);
                dbContext.SaveChanges();
                StudentDatagrid.ItemsSource = dbContext.Students.ToList();
                InsertBtn.IsEnabled = true;
                studentGrid.DataContext = null;
            }
            else
                MessageBox.Show("Please insert FIRSTNAME and LASTNAME !"," ERROR !", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            fnameTxt.Text = "";
            lnameTxt.Text = "";
            phoneTxt.Text = "";
            //survetCmb.Text = "";
            datepicker.SelectedDate = default;
            //moderatorCmb.Text = "";
        }

        private void searchtxt_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = dbContext.Students.Where(fname => fname.Fname.StartsWith(searchtxt.Text) || fname.Lname.StartsWith(searchtxt.Text)).ToList();
            StudentDatagrid.ItemsSource = filtered;
        }
    }
}
