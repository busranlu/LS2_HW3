using KodlamaIO.Bussiness.Abstracts;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Bussiness.Concretes
{
    internal class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> Read()
        {
            return _categoryDal.Read();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }






    }
}
