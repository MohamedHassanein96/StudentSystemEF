using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemEF.Models
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string Name { get; set; } = null!;
        public string? URL { get; set; }
        public ResourceType Type { get; set; }
        public enum ResourceType
        {
            Video,
            Presentation,
            Document,
            Other

        }
        public int CourseID { get; set; }
        public Course Course { get; set; } = null!;

    }
}
