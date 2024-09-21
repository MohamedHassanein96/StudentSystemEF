using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public ICollection<Student> Students { get; } = [];
        public ICollection<Homework> Homeworks { get; } = [];
        public ICollection<Resource> Resources { get; } = [];
        
    }
}
