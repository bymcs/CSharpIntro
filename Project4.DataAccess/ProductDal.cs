using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {

            _products = new List<Product>
            {
                new Product { ProductId = 1, ProductName="Lenovo Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=4 },
                new Product { ProductId = 2, ProductName="Dell Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitsInStock=7 },
                new Product { ProductId = 3, ProductName="HP Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=6000, UnitsInStock=2 },
                new Product { ProductId = 4, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=9000, UnitsInStock=1 },
                new Product { ProductId = 5, ProductName="Acer Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=5000, UnitsInStock=0 },
                new Product { ProductId = 6, ProductName="MSI Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=12000, UnitsInStock=3 },
                new Product { ProductId = 7, ProductName="Apple MacBook", QuantityPerUnit="16 GB RAM", UnitPrice=15000, UnitsInStock=6 },
                new Product { ProductId = 8, ProductName="Microsoft Surface", QuantityPerUnit="8 GB RAM", UnitPrice=12000, UnitsInStock=2 },
                new Product { ProductId = 9, ProductName="Huawei MateBook", QuantityPerUnit="16 GB RAM", UnitPrice=9000, UnitsInStock=5 },
                new Product { ProductId = 10, ProductName="Samsung Notebook", QuantityPerUnit="8 GB RAM", UnitPrice=7000, UnitsInStock=8 }
            };

        }

        public void Add(Product product)
        {
            Console.WriteLine("Eklendi");
        }

        public List<Product> GetAll() 
        {

            return _products; 
        
        }



    }
}
