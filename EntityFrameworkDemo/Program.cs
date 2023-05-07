namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext northwindContext = new NorthwindContext();
            Console.WriteLine("Hello, World!");
            Console.WriteLine(northwindContext.Products);


            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}