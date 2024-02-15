using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Create(Instructor ınstructor);
        void Delete(Instructor ınstructor);
        void Update(Instructor ınstructor);
        List<Instructor> Read();
    }
}
