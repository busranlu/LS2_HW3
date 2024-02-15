using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Bussiness.Abstracts
{
    internal interface ICourseManager
    {
        List<Course> Read(Course course);
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
