using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? InstructorName { get; set; }
        public string? InstructorSurname { get; set; }
        public string? InstructorDescription { get; set; }

        public List<Course> Courses { get; set; }

    }
}
