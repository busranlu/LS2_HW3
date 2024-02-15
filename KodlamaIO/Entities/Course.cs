using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities
{
    public class Course
    {
        public int CourseId { get; set; } 
        public string CourseName { get; set; }
        public int CourseLevel { get; set; }
        public string CourseTrainer { get; set; }
        public Category Category { get; set; }


    }
}
