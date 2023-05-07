namespace AsyncDemo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

            //Task task1 = new Task(Process1);
            //task1.Start();

            //Task task1 = Task.Factory.StartNew(Process1);

            //Task task = Task.Run(Process1);

            //Task task = Task.Run(() => {
            //    Process2();
            //    Process1();
            //});
            
            Task task1 = Task.Factory.StartNew(Process1);

            Process2();

            
            
            Console.WriteLine("Console bitti");
            Console.ReadLine();

        }


        static void Process1()
        {
            Console.WriteLine($"Process1 Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process2()
        {
            Console.WriteLine($"Process2 Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}