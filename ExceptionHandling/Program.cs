using System.Reflection.Metadata;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Matematik matematik = new Matematik();
            
            Console.WriteLine(matematik.Topla(10,5));

            Console.WriteLine(matematik.Bol(5, 0));

        }
    }

    class Matematik
    {
        public int Topla(int sayi1,int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public double Bol(int sayi1, int sayi2)
        {
            try
            {
                return (sayi1 / sayi2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 BÖLÜNEMEZ");
                //throw new DivideByZeroException("0 gg");
                return 0;
            }

            catch (Exception exception)
            {
                Console.WriteLine("HATA VAR");
                Console.WriteLine(exception.InnerException);
                throw;
            }
            finally 
            { 
                Console.WriteLine("finally çalıştı"); 
            }

        }
    }
}