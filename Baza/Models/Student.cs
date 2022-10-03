using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Survey { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Moderator { get; set; }
        public ICollection<Group> Groups { get; set; }

        public string Fullname
        {
            get
            {
                return Lname + " " + Fname;
            } 
        }
        public Student()
        {
            this.Groups = new List<Group>();
        }

        public override string ToString()
        {
            return Fname + " " + Lname;
        }

    }
}
