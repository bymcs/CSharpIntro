namespace AsyncDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread no : {Thread.CurrentThread.ManagedThreadId}");

            Process1Async();

            Process2Async();



            Process1();
            Process2();

        }
        static void Process1()
        {
            Console.WriteLine($"Senkron1 Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process1Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Async1 Thread no : {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        static void Process2()
        {
            Console.WriteLine($"Senkron2 Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }
        static async Task Process2Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Async2 Thread no : {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }

}