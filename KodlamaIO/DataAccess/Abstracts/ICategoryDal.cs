using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Create(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> Read();
    }
}
