using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Lenovo Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 10000, UnitsInStock = 4 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "HP Laptop", QuantityPerUnit = "16 GB RAM", UnitPrice = 8000, UnitsInStock = 5 },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Dell Laptop", QuantityPerUnit = "8 GB RAM", UnitPrice = 6000, UnitsInStock = 3 },
                new Product { ProductId = 4, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "16 GB RAM", UnitPrice = 7000, UnitsInStock = 2 },
                new Product { ProductId = 5, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 9000, UnitsInStock = 6 },
                new Product { ProductId = 6, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB RAM", UnitPrice = 3000, UnitsInStock = 10 },
                new Product { ProductId = 7, CategoryId = 2, ProductName = "iPhone Telefon", QuantityPerUnit = "8 GB RAM", UnitPrice = 5000, UnitsInStock = 8 },
                new Product { ProductId = 8, CategoryId = 2, ProductName = "Xiaomi Telefon", QuantityPerUnit = "6 GB RAM", UnitPrice = 2500, UnitsInStock = 12 },
                new Product { ProductId = 9, CategoryId = 2, ProductName = "Huawei Telefon", QuantityPerUnit = "6 GB RAM", UnitPrice = 4000, UnitsInStock = 7 },
                new Product { ProductId = 10, CategoryId = 2, ProductName = "OnePlus Telefon", QuantityPerUnit = "8 GB RAM", UnitPrice = 3500, UnitsInStock = 9 }
            };

            //Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            AscDescTest(products);

        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.CategoryId == 2);
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 6);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Lenovo Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("ALGORİTMİK ----------------------------------");

            foreach (var item in products)
            {
                if (item.UnitPrice > 8000)

                    Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("LİNQ ----------------------------------");

            var result = products.Where(p => p.UnitPrice > 8000);

            foreach (var item in result)
            {
                Console.Write(item.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5800 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 8000).ToList();
        }



        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}