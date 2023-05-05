namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Product product = new Product();

            product.Id = 1;
            Console.WriteLine(product.Id);
            product.UnitsInStock = 50;
            Console.WriteLine(product.UnitsInStock);
            //product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);


        }
    }

    class Product
    {
        public Product()
        {
            _UnitPrice = 1000;
        }
        
 
        
        decimal _UnitPrice;

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice 
        { 
            get { return _UnitPrice + _UnitPrice * 18 / 100; } 
            set { _UnitPrice = value; } 
        }
        
        public decimal UnitsInStock;

    } 




}