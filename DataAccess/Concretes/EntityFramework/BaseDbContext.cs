using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    //Veri tabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {   
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Tobeto4A;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
