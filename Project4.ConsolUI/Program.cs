using Project4.Business;
using Project4.DataAccess;

namespace Project4.ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());

            foreach (var product in productManager.GetAll())
            {

                Console.WriteLine(product.ProductName);

            }

        }
    }
}