using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId= 1;
            course1.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course1.CourseTrainer = "Engin Demiroğ";
            course1.CourseLevel = 0;

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)";
            course2.CourseTrainer = "Engin Demiroğ";
            course2.CourseLevel = 0;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.CourseTrainer = "Halit Enes Kalaycı";
            course3.CourseLevel = 0;

            courses = new List<Course> { course1, course2, course3 };
            
        }

        public void Create(Course course) 
        {
            courses.Add(course);
        
        }
        public void Delete(Course course)
        {
            courses.Remove(course);
        }   
        public void Update(Course course)
        {
            Course courseUpdated = new Course();
            courseUpdated.CourseId= course.CourseId;
            //add update value bloks
        }
        public List<Course> Read()
        {
            return courses;
        }






    }
}
