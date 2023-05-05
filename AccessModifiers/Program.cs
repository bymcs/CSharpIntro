namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Id = 80;
            house.City = "TEST";

            Console.WriteLine(house.Id + " " + house.City);
        }
    }

    class Customer
    {

    }
}