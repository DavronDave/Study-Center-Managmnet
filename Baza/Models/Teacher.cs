using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public string Fullname
        {
            get
            {
                return Fname + " " + Lname;
            }
        }
        public ICollection<Group> Groups { get; set; }
        public override string ToString()
        {
            return Fname + " " + Lname;
        }
    }
}
