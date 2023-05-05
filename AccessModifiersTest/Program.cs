using AccessModifiers;

namespace AccessModifiersTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();    
            house.Id = 1;
            house.City = "Adana";

            Console.WriteLine(house.Id+" "+house.City);
            
        }
    }
}