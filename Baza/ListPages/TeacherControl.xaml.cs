using baza.Datalayer;
using baza.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for TeacherControl.xaml
    /// </summary>
    public partial class TeacherControl : UserControl
    {
        StudyCenterDbContext dbContext;
        public TeacherControl()
        {
           
            InitializeComponent();
            //LoadAll();
        }
        

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ism.Text!="" && fam.Text!="" && tel.Text!="")
            {
                Teacher teacher = new Teacher();
                teacher.Fname = ism.Text;
                teacher.Lname = fam.Text;
                teacher.Phone = tel.Text;
                teacher.SubjectId = ((Subject)comboSubject.SelectedItem).SubjectId;

                dbContext.Teachers.Add(teacher);
                dbContext.SaveChanges();

                TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
                ism.Text = "";
                fam.Text = "";
                tel.Text = "";
                comboSubject.Text = "";
            }
            MessageBox.Show("Please insert data");
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
            TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
            SubjectDatagrid.ItemsSource = dbContext.Subjects.OrderBy(x => x.Name).ToList();
            roomDatagrid.ItemsSource = dbContext.Rooms.OrderBy(x => x.Name).ToList();
            comboSubject.ItemsSource = dbContext.Subjects.OrderBy(x => x.Name).ToList();
            //dbContext = new StudyCenterDbContext();
            //var item = dbContext.Subjects.ToList();
            //subj = item;
            //comboSubject.DataContext = subj;
            //SubjNameTxb.Text = "";

            //StudyCenterDbContext dbContext1 = new StudyCenterDbContext();
            //var item1 = dbContext.Rooms.ToList();
            //room = item1;
            //roomNameTxb.DataContext = room;
            SubjNameTxb.Text = "";
        }

        public List<Student> stu { get; set; }

        public void LoadAll()
        {
            dbContext = new StudyCenterDbContext();
            var item = dbContext.Students.ToList();
            stu = item;
            DataContext = stu;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Update(teacher);
            dbContext.SaveChanges();
            TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
            SubjectDatagrid.ItemsSource = dbContext.Subjects.ToList();
        }


        public Teacher teacher = new Teacher();
        public Subject Subject = new Subject();
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var techId = (TeacherDatagrid.SelectedItem as Teacher).TeacherId;
                var teacherToBeDeleted = dbContext.Teachers.Where(x => x.TeacherId == techId).SingleOrDefault();
                
                dbContext.Teachers.Remove(teacherToBeDeleted);
                dbContext.SaveChanges();
                TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
            }
        }
        private void SubjEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Subject = (sender as FrameworkElement).DataContext as Subject;
            subStack.DataContext = Subject;
            addSubBtn.IsEnabled = false;
        }
        
        private void SubjdeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ////var subId = (sender as Subject).SubjectId;
                //StackPanel stackPanel = (sender as Button).Content as StackPanel;
                //Label id = stackPanel.Children[2] as Label;
                //int subId =(int)id.Content;
                var subId = (SubjectDatagrid.SelectedItem as Subject).SubjectId;
                var subjectToBeDeleted = dbContext.Subjects.Where(x => x.SubjectId == subId).SingleOrDefault();
                dbContext.Subjects.Remove(subjectToBeDeleted);
                dbContext.SaveChanges();

                TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
                SubjectDatagrid.ItemsSource = dbContext.Subjects.ToList();
                comboSubject.ItemsSource = dbContext.Subjects.ToList();
            }
        }

        private void addSubBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SubjNameTxb.Text != "")
            {
                Subject subject = new Subject();
                subject.Name = SubjNameTxb.Text;
                dbContext.Subjects.Add(subject);
                dbContext.SaveChanges();
                SubjNameTxb.Text = "";
                SubReqTxt.Text = "";
                MessageBox.Show("Added subject to database");
                SubjectDatagrid.ItemsSource = dbContext.Subjects.ToList();
                comboSubject.ItemsSource = dbContext.Subjects.ToList();
            }
            else
                SubReqTxt.Text = "Enter SUBJECT NAME!";
        }

        private void UpdSubBtn1_Click(object sender, RoutedEventArgs e)
        {
            // dbContext.Entry(Subject).State = EntityState.Modified;
            if (SubjNameTxb.Text != "")
            {
                dbContext.Update(Subject);
                dbContext.SaveChanges();
                SubjectDatagrid.ItemsSource = dbContext.Subjects.ToList();
                SubjNameTxb.Text = "";
                SubReqTxt.Text = "";
                addSubBtn.IsEnabled = true;
            }
            else
                MessageBox.Show("Please select SUBJECT !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void searchtxt_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = dbContext.Teachers.Where(fname => fname.Fname.StartsWith(searchtxt.Text) || fname.Lname.StartsWith(searchtxt.Text)).ToList();
            TeacherDatagrid.ItemsSource = filtered;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            teacher = (sender as FrameworkElement).DataContext as Teacher;
            editGrid.DataContext = teacher;
            comboSubject.SelectedValue = teacher.SubjectId;
            InsertBtn.IsEnabled = false;
        }

        private Room room = new Room();
        private void roomEditBtn_Click(object sender, RoutedEventArgs e)
        {
            room = (sender as FrameworkElement).DataContext as Room;
            roomGrid.DataContext = room;
            addroomBtn.IsEnabled = false;
        }

        private void roomdeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var roomId = (roomDatagrid.SelectedItem as Room).RoomId;
                var subjectToBeDeleted = dbContext.Rooms.Where(x => x.RoomId == roomId).SingleOrDefault();
                dbContext.Rooms.Remove(subjectToBeDeleted);
                dbContext.SaveChanges();
                roomDatagrid.ItemsSource = dbContext.Rooms.ToList();
            }
        }

        private void addroomBtn_Click(object sender, RoutedEventArgs e)
        {
            if (roomNameTxb.Text != "")
            {
                Room room = new Room();
                room.Name = roomNameTxb.Text;
                dbContext.Rooms.Add(room);
                dbContext.SaveChanges();

                roomNameTxb.Text = "";
                SubReqTxt1.Text = "";
                MessageBox.Show("Subject added to database");
                roomDatagrid.ItemsSource = dbContext.Rooms.ToList();
            }
            else
                SubReqTxt1.Text = "Enter ROOM NAME!";
        }

        private void UpdroomBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (roomNameTxb.Text != "")
            {
                dbContext.Update(room);
                dbContext.SaveChanges();
                roomDatagrid.ItemsSource = dbContext.Rooms.ToList();
                roomNameTxb.Text = "";
                SubReqTxt1.Text = "";
                addroomBtn.IsEnabled = true;
            }
            else
                MessageBox.Show("Please select ROOM!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void updateBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (ism.Text != "" && tel.Text != "")
            {
                dbContext.Entry(teacher).State = EntityState.Modified;
                // teacher.SubjectId = (int)comboSubject.SelectedIndex;
                dbContext.Update(teacher);
                dbContext.SaveChanges();
                TeacherDatagrid.ItemsSource = dbContext.Teachers.ToList();
                InsertBtn.IsEnabled = true;
                TeacherDatagrid.SelectedItem = comboSubject.SelectedItem;
                editGrid.DataContext = null;
                comboSubject.SelectedItem = null;
            }
            else
                MessageBox.Show("Please select TEACHER!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void deleteTeachBtn_Click(object sender, RoutedEventArgs e)
        {
            ism.Text = "";
            fam.Text = "";
            tel.Text = "";
        }

        private void clearSubBtn_Click(object sender, RoutedEventArgs e)
        {
            SubjNameTxb.Text = "";
            SubjectDatagrid.SelectedItem = null;
            addSubBtn.IsEnabled = true;
        }

        private void clearroomBtn_Click(object sender, RoutedEventArgs e)
        {
            roomNameTxb.Text = "";
        }

        private void SubjectDatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
