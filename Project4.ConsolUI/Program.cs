using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;

namespace Project4.ConsolUI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ProductManager productManager = new ProductManager(new EFProductDal());


            foreach (var product in productManager.GetAllAsync().Result)
            {
                Console.WriteLine(product.UnitPrice + " -- " + product.ProductName);

            }


            //productManager.Add(new Product { ProductName = "Masa", CategoryId = 1, QuantityPerUnit = "1 AYAKLI MASA", UnitPrice = 2500, UnitsInStock = 5 });

            //productManager.Update(new Product { ProductId=78,ProductName = "Masa V3", CategoryId = 2, QuantityPerUnit = "4 AYAKLI MASA", UnitPrice = 1000, UnitsInStock = 25 });

            //productManager.Delete(new Product { ProductId = 78 });

            //Console.WriteLine(productManager.GetById(1).ProductName);



            //try
            //{
            //    productManager.Add(new Entities.Product { ProductId = 11, ProductName = "Laptop", QuantityPerUnit = "4 Ayaklı masa", UnitPrice = 200, UnitsInStock = 4 });
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}



            //PersonelManager personelManager = new PersonelManager( new EfPersonelDal());

            //foreach(var personel in personelManager.GetAll())
            //{
            //    Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Name, personel.Surname);
            //}
        }
    }
}