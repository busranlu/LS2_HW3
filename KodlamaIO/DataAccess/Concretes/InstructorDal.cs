using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> Instructors;

        public InstructorDal() 
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.InstructorName = "Engin";
            instructor1.InstructorSurname = "Demirog";
            instructor1.InstructorDescription = "asdfgh....";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.InstructorName = "Halit";
            instructor2.InstructorSurname = "Enes Kalaycı";
            instructor2.InstructorDescription = "asdfghj....";

            Instructors = new List<Instructor> { instructor1,instructor2 };
        }
        public void Create(Instructor ınstructor)
        {
            Instructors.Add(ınstructor);

        }
        public void Delete(Instructor ınstructor)
        {
            Instructors.Remove(ınstructor);
        }
        public void Update(Instructor ınstructor)
        {
            Instructor ınstructorUpdated = new Instructor();
            ınstructorUpdated.InstructorId = ınstructor.InstructorId;
            //add update value bloks
        }
        public List<Instructor> Read()
        {
            return Instructors;
        }



    }
}
