using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager :ICategoryService
    {
        List<Category> categories;

        public CategoryManager(List<Category> categories)
        {
            this.categories = categories;     
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.Find(x => x.Id == id);
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
    
}
