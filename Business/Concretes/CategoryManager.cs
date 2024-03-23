using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> categories;

        public CategoryManager()
        {
            this.categories = new List<Category>();
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            categories.Remove(GetById(id));
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.Find(x => x.Id == id); //LINQ sorgusu ile burada bir foreach döngüsüyle verilen id'yi category içerisinde 
                                                     //arıyoruz eğer ideşleşiyorsa bize getiriyor eşleşmiyorsa null dönüyor.Bunu basit bir 
                                                     //if sorgusuyla da yapabilirdik.
        }

        public void Update(Category category)
        {
            int id = category.Id;
            Category categoryId = GetById(id);//GetById metodunu kullanarak, verilen id değerine sahip kategori nesnesi bulunmaya çalışılır.
                                              //Bu bulunan kategori nesnesi categoryId adlı bir değişkene atanır.

            if (categoryId != null)
            {
                int index= categories.IndexOf(categoryId);
                categories[index] = category;
            }
            else
            {
                throw new Exception("Güncellenecek veri bulunamadı");
            }
        }
    }

}
