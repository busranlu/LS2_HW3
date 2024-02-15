using KodlamaIO.Bussiness.Abstracts;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Bussiness.Concretes
{
    internal class CourseManager : ICourseManager
    {
        ICourseDal _courseDal;
        private CourseDal courseDal;

        public CourseManager(CourseDal courseDal)
        {
            this.courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Create(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> Read(Course course)
        {
            return _courseDal.Read();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
