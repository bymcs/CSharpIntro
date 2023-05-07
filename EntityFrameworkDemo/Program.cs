namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext northwindContext = new NorthwindContext();
            //Console.WriteLine("Hello, World!");


            foreach (var p in northwindContext.Products)
            {
                Console.WriteLine(p.ProductId+" "+p.ProductName+" "+p.UnitPrice);
            }
        }
    }
}