using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType Type { get; set; }  
        public enum ContentType
        {
            Application,
            Pdf,
            Zip
        }
        public DateTime SubmissionTime { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseID { get; set; }
        public Course Course { get; set; } =null!;


    }
}
