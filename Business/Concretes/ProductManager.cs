using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {
            products.Remove(GetById(id));
        }

        public List<Product> GetAll()
        {
            return this.products;
        }

        public Product GetById(int id)
        {
            return products.Find(y => y.Id == id);
        }

        public void Update(Product product)
        {
            int id = product.Id;
            Product productId = GetById(id);

            if (productId!=null)
            {
                int indexProduct=products.IndexOf(productId);
                products[indexProduct]= product;
            }
            else
            {
                throw new Exception("Güncellenecek ürün bulunamadı.");
            }
        }
    }
}