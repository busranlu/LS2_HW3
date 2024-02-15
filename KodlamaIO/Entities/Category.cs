using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategortyName { get; set; }

        public List<Course> Courses { get; set; }

    }
}
