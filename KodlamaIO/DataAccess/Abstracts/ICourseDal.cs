using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Create(Course course);
        void Delete(Course course);
        void Update(Course course);
        List<Course> Read();
    }
}
