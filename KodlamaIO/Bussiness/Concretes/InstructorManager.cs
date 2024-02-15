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
    internal class InstructorManager : IInstructorManager
    {
        IInstructorDal _instructorDal;
        private InstructorDal ınstructorDal;

        public InstructorManager(InstructorDal ınstructorDal)
        {
            this.ınstructorDal = ınstructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Create(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> Read(Instructor instructor)
        {
            return _instructorDal.Read();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
