using KodlamaIO.Bussiness.Abstracts;
using KodlamaIO.Bussiness.Concretes;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICourseManager _courseService = new CourseManager(new CourseDal());
            ICategoryManager _categoryService = new CategoryManager(new CategoryDal());
            IInstructorManager _instructorService = new InstructorManager(new InstructorDal());

            //Add 
            _categoryService.Add(new Category()
            {
                CategoryId = 1,
                CategortyName = "Python"
            });

            _courseService.Add(new Course()
            {
                CourseId = 2,
                CourseLevel = 1,
                CourseName="ML basics",
                CourseTrainer="asd fds"
            });

            _instructorService.Add(new Instructor()
            {
                InstructorDescription="asd....asd..s.s.s.s.",
                InstructorId=4,
                InstructorName="aslk",
                InstructorSurname="arsda",
            });

            //Delete
            _categoryService.Delete(new Category()
            {
                CategoryId = 1,
            });


            foreach (Category category in _categoryService.Read())
            {
                Console.WriteLine($"Category ID: {category.CategoryId}");
                Console.WriteLine($"Category Name: {category.CategortyName}");
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine();

        }
    }
}