namespace Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ProductManager productManager = new ProductManager();

            productManager.Add();

            Matematik matematik = new Matematik();

            int sonuc = matematik.Topla(10, 10);

            Console.WriteLine(sonuc);
            
            int sonuc2 = matematik.ToplaParams(2,2,2,2,2,1);

            Console.WriteLine(sonuc2);

        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2 = 100)
        {
            return sayi1 + sayi2;
        }

        public int ToplaParams(params int[] sayilar)
        {

            //int sum = 0;
            //foreach (int i in sayilar)
            //{
            //    sum = sum + i;
            //}
            //return sum;

            return sayilar.Sum();

        }

        public int Cikar(int sayi1, int sayi2 = 100)
        {
            return sayi1 - sayi2;
        }



    }
}