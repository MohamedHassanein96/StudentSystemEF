using System;
using StudentSystemEF.Models;
using StudentSystemEF.Data;
using System.Linq;


namespace StudentSystemEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();
                {
                    Console.WriteLine("Enter Student Name:");
                    string studentName = Console.ReadLine();

                    Console.WriteLine("Enter Student Phone Number:");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter Student Birthday as (1996-09-27):");
                    DateTime birthday = DateTime.Parse(Console.ReadLine());

                    var student = new Student()
                    {
                        Name = studentName,
                        PhoneNumber = phoneNumber,
                        Birthday = birthday,
                        RegisteredOn = DateTime.Now
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                    Console.WriteLine("Student Added");


                    Console.WriteLine("Enter Course Name:");
                    string courseName = Console.ReadLine();

                    Console.WriteLine("Enter Course Description:");
                    string courseDescription = Console.ReadLine();

                    Console.WriteLine("Enter Course StartDate (2020-02-22):");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Course EndDate (2020-02-22):");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Course Price:");
                    int coursePrice = int.Parse(Console.ReadLine());


                    var course = new Course()
                    {
                        Name = courseName,
                        Description = courseDescription,
                        StartDate = startDate,
                        EndDate = endDate,
                        Price = coursePrice
                    };
                    context.Courses.Add(course);
                    context.SaveChanges();
                    Console.WriteLine("Course Added");
                }

            }
        }
    }
}
