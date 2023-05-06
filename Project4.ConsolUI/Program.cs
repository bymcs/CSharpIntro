using Project4.Business;
using Project4.DataAccess;

namespace Project4.ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }

            try
            {
                productManager.Add(new Entities.Product { ProductId = 11, ProductName = "Laptop", QuantityPerUnit = "4 Ayaklı masa", UnitPrice = 200, UnitsInStock = 4 });
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}