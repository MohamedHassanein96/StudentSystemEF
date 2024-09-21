using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Models
{
    public class Student
    {
        public int StudentID{ get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime?  Birthday { get; set; }
        public  ICollection<Course> Courses { get; } = [];
        public ICollection<Homework> Homeworks { get; } = new List<Homework>();

    }
}
