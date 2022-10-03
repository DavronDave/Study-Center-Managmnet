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
    /// Interaction logic for GroupControl.xaml
    /// </summary>
    public partial class GroupControl : UserControl
    {
        public GroupControl()
        {
            InitializeComponent();
        }

        StudyCenterDbContext dbContext;
        public List<Subject> subj { get; set; }
        public List<Teacher> teach { get; set; }
        public List<Room> room { get; set; }        
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {      
            dbContext = new StudyCenterDbContext();
            
            var item = dbContext.Subjects.ToList();
            subj = item;
            subjectcmb.DataContext = subj;

            var item1 = dbContext.Teachers.ToList();
            teach = item1;
            teachercmb.DataContext = teach;


            var item2 = dbContext.Rooms.ToList();
            room = item2;
            roomcmb.DataContext = room;
            dbContext.Groups.Load();
            //dbContext.Teachers.Load();
            //dbContext.Rooms.Load();
            //dbContext.Subjects.Load();
            //GroupDatagrid.ItemsSource = dbContext.Groups.Local.Select(g => new
            //{
            //    Name = g.Name,
            //    Duration = g.Duration,
            //    StartDate = g.StartDate,
            //    StartLesson = g.StartLesson,
            //    FinishLesson = g.FinishLesson,
            //    Room = g.Room.Name,
            //    Teacher = g.Teacher.ToString(),
            //    Subject = g.Teacher.Subject.Name
            //});

            GroupDatagrid.ItemsSource = dbContext.Groups.ToList();
           
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext = new StudyCenterDbContext();
           
            if (gnameTxt.Text != "")
            {
                Group group = new Group(); 
                group.Name = gnameTxt.Text;
                group.TeacherId = (int)teachercmb.SelectedValue;
                group.Duration = Convert.ToInt32(durTxt.Text);
                group.StartDate = datepicker.SelectedDate;
                group.StartLesson = startlessoncmb.Text;
                group.FinishLesson = finishlessoncmb.Text;
                group.RoomId = (int)roomcmb.SelectedValue;
                dbContext.Groups.Add(group);
                dbContext.SaveChanges();

                durTxt.Text = "";
                datepicker.SelectedDate = default;
                GroupDatagrid.DataContext = null;
                //GroupDatagrid.ItemsSource = dbContext.Groups.ToList();
            }
            else
                MessageBox.Show("Please insert GROUP data!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        public Group Group = new Group();
        private void updateCellBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Group = (sender as FrameworkElement).DataContext as Group;
            //Group = GroupDatagrid.SelectedItem as Group;
            GroupGrid.DataContext = Group;
        }
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var groupId = (GroupDatagrid.SelectedItem as Group).GroupId;
                var studentToBeDeleted = dbContext.Groups.Where(x => x.GroupId == groupId).SingleOrDefault();

                dbContext.Groups.Remove(studentToBeDeleted);
                dbContext.SaveChanges();

                GroupDatagrid.ItemsSource = dbContext.Groups.ToList();
            }
        }

        private void addStudents_Click(object sender, RoutedEventArgs e)
        {
             studentsLbx.ItemsSource = dbContext.Students.OrderByDescending(x => x.StudentId).ToList();
            //studentsLbx.ItemsSource = dbContext.Groups.Include(x => x.Students).ToList();
            //context.StudentCourses.Include(x => x.Student).Where(entry => entry.CourseId == theIdYouWant).Select(entry => entry.Student)

            // havestudentsLbx.ItemsSource = dbContext.Groups.Include(x => x.Students).Where(e => e.GroupId == id).Select(x => x.Students).ToList();

            var idG = (GroupDatagrid.SelectedItem as Group).GroupId;

            //var query = dbContext.Groups.GroupJoin(
            //    dbContext.Groups.Include(x => x.Students),
            //    gr => gr.GroupId,
            //    st => st.Students.Select(id => id.StudentId),
            //    (gr, st) => new { gr, st });

            //foreach (var item in query)
            //{
            //    havestudentsLbx.ItemsSource = item.gr.Name;
            //    foreach (var item1 in item.st) 
            //    {
            //        havestudentsLbx.ItemsSource = item1.Fullname;
            //    }
            //}

            var query = from article in dbContext.Groups
                        where article.Students.Any(c => c.StudentId == idG)
                        select article.Name;

           
        }
       
        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            // Group = (sender as FrameworkElement).DataContext as Group;
            var group = (Group)GroupDatagrid.SelectedItem;
            var student = studentsLbx.SelectedItem as Student;
            group.Students.Add(student);
            // dbContext.Groups.Add(group);
            dbContext.SaveChanges();
        }
    }
}
