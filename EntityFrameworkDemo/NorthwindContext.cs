using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost;Database=Northwind;User Id=sa;Password=bymcancan1;TrustServerCertificate=True;");
        
        }

        public DbSet<Product> Products { get; set; }

    }


       
}
