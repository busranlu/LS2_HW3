using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategortyName= "C#";

            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategortyName = "Java";

            Category category3 = new Category();
            category3.CategoryId = 3;
            category3.CategortyName = "Python";

            categories = new List<Category> { category1,category2,category3 };

        }

        public void Create(Category category)
        {
            categories.Add(category);

        }
        public void Delete(Category category)
        {
            categories.Remove(category);
        }
        public void Update(Category category)
        {
            Category categoryUpdated = new Category();
            categoryUpdated.CategoryId = category.CategoryId;
            //add update value blocks
        }
        public List<Category> Read()
        {
            return categories;
        }

    }
}
