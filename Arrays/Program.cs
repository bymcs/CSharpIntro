namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] krediler = new string[7];
            krediler[0] = "A";
            krediler[1] = "B";
            krediler[2] = "C";
            krediler[3] = "D";
            krediler[4] = "E";
            krediler[5] = "F";
            krediler[6] = "H";

            foreach (var s in krediler)
            {
                Console.WriteLine(s);
                break;
            }


            Console.WriteLine("\n");

            for (int i = 0; i < krediler.Length; i++)
            {
                Console.WriteLine(krediler[i]);
            }


        }
    }
}