using baza.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza.Datalayer
{
    public class StudyCenterDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Login> Logins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Data Source = WIN-TV2EHI007FV; Initial Catalog = StudyCenterDB14; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(path);
        }
    }
}
