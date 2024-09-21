using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Models
{
    public class StudentCourse
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Student Student { get; set; } = null!;
            
        public Course Course { get; set; } = null!;

    }
}
