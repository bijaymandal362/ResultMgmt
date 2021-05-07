using Microsoft.EntityFrameworkCore;
using ResultManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Name = "Bijay Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 2, Name = "Sunil Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 3, Name = "Ajay Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 4, Name = "Mohan Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 5, Name = "Sanu Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 6, Name = "Sabch Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 7, Name = "Neha Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 8, Name = "Suhant Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 9, Name = "Dev Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 10, Name = "Krsishana Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 11, Name = "krish Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 12, Name = "Deb Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 13, Name = "Avbch Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 14, Name = "Mehana Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 15, Name = "Shub Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 16, Name = "Arohi Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 17, Name = "Abc Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 18, Name = "Sunhm Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 19, Name = "suman Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 20, Name = "Saroj Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" },
                new Student() { StudentId = 21, Name = "Krishna Mandal", ParentName = "Bibek Mandal", ParentEmail = "mbijay833@gmail.com" });

            modelBuilder.Entity<Classes>().HasData(
                new Classes() { ClassId = 1, Class = "Nursery", StudentId = 1, },
                new Classes() { ClassId = 2, Class = "Nursery", StudentId = 2, },
                new Classes() { ClassId = 3, Class = "Nursery", StudentId = 3, },
                new Classes() { ClassId = 4, Class = "Nursery", StudentId = 4, },
                new Classes() { ClassId = 5, Class = "Nursery", StudentId = 5, },
                new Classes() { ClassId = 6, Class = "Nursery", StudentId = 6, },
                new Classes() { ClassId = 7, Class = "LKG", StudentId = 7, },
                new Classes() { ClassId = 8, Class = "LKG", StudentId = 8, },
                new Classes() { ClassId = 9, Class = "LKG", StudentId = 9, },
                new Classes() { ClassId = 10, Class = "LKG", StudentId = 10, },
                new Classes() { ClassId = 11, Class = "LKG", StudentId = 11, },
                new Classes() { ClassId = 12, Class = "LKG", StudentId = 12, },
                new Classes() { ClassId = 13, Class = "LKG", StudentId = 13, },
                new Classes() { ClassId = 14, Class = "UKG", StudentId = 14, },
                new Classes() { ClassId = 15, Class = "UKG", StudentId = 15, },
                new Classes() { ClassId = 16, Class = "UKG", StudentId = 16, },
                new Classes() { ClassId = 17, Class = "UKG", StudentId = 17, },
                new Classes() { ClassId = 18, Class = "UKG", StudentId = 18, },
                new Classes() { ClassId = 19, Class = "UKG", StudentId = 19, },
                new Classes() { ClassId = 20, Class = "UKG", StudentId = 20, },
                new Classes() { ClassId = 21, Class = "UKG", StudentId = 21 });

        }
                                                               
        public DbSet<Course> Courses { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Classes> Classes { get; set; }




    }
}
