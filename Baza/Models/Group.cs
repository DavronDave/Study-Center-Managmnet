using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartLesson { get; set; }
        public string FinishLesson { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            this.Students = new List<Student>();
        }

    }
}
