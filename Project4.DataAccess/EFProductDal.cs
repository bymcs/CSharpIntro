using Microsoft.EntityFrameworkCore;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {


        public EFProductDal()
        {

        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Add(product);
                context.SaveChanges();
            }
        }

        public async Task AddAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();
            await context.AddAsync(product);
            await context.SaveChangesAsync();

        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges();
            }
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Task<List<Product>> GetAllAsync()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Products.ToListAsync();
        }    

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductId == id);
            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);

                productToUpdate.ProductId = product.ProductId;
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;
                context.SaveChanges();

            }
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
