using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Bussiness.Abstracts
{
    internal interface ICategoryManager
    {
        void Add(Category category);
        List<Category> Read();
        void Update(Category category);
        void Delete(Category category);
    }
}
