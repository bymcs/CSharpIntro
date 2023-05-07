namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAll();

            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var p in northwindContext.Products)
            {
                Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.UnitPrice);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {

            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


        }

    }
}