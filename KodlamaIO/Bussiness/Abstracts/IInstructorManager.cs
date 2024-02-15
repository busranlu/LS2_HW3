using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Bussiness.Abstracts
{
    internal interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> Read(Instructor instructor);
       
    }
}
