using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public Category()
        {
        }
        public Category(int id,string categoryName)
        {
            Id= id;
            CategoryName= categoryName;
            
            //Description alanının nesne oluştururken gerekli olmadığı kanısına vardığımız için 
            //ctor içerisinde description tutmadık.
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
