namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };

            sehirler2.Add("Bursa");

            foreach (string s in sehirler2)
            {
                Console.WriteLine(s);
            }



        }
    }
}