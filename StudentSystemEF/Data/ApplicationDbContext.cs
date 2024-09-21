using Microsoft.EntityFrameworkCore;
using StudentSystemEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Data
{
    internal class ApplicationDbContext : DbContext
        
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentID, sc.CourseID });


            modelBuilder.Entity<Student>()
                .Property(b => b.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            modelBuilder.Entity<Student>()
                .Property(b => b.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(b => b.Birthday);
                

            modelBuilder.Entity<Course>()
                .Property(b => b.Name)
                .IsUnicode(true)
                .HasMaxLength(80);

            modelBuilder.Entity<Course>()
                .Property(b => b.Description)
                .IsUnicode(true)
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(b => b.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                .Property(b => b.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Homework>()
                .Property(b => b.Content)
                .IsUnicode(false);

           
            modelBuilder.Entity<Course>()
               .HasData(new Course { CourseID = 1, Name = "C#", Description = "basic of C#", StartDate = new DateTime(2024, 9, 1), EndDate = new DateTime(2024, 10, 1), Price = 800 });

            modelBuilder.Entity<Student>()
               .HasData(new Student { StudentID = 1, Name = "Mohamed", Birthday = new DateTime(1996, 9, 8), PhoneNumber = "1015335676", RegisteredOn = new DateTime(2020, 2, 1) });

            modelBuilder.Entity<Resource>()
                .HasData(new Resource { ResourceID = 1, Name = "Microsoft Tutorial", URL = "https://learn.microsoft.com/", CourseID = 1, Type = Resource.ResourceType.Document });

            modelBuilder.Entity<Homework>()
                .HasData(new Homework { HomeworkId = 1, Content = " DataType", SubmissionTime = DateTime.Now, StudentID = 1, CourseID = 1,Type=Homework.ContentType.Pdf });




        }


    }
}
