namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {

        public void Add() {

            Console.WriteLine("Müşteri Eklendi");
        }
        public void Update()
        {

            Console.WriteLine("Müşteri güncellendi");
        }

    }

    class EmployeeManager : IPersonManager
    {

        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }
        public void Update()
        {

            Console.WriteLine("Personel güncellendi");
        }

    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi");
        }
        public void Update()
        {

            Console.WriteLine("Stajer güncellendi");
        }
    }


    class ProjectManager
    {

        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        //public void AddCustomer(CustomerManager customerManager)
        //{
        //    customerManager.Add();
        //}
        //public void AddEmployee(EmployeeManager employeeManager)
        //{
        //    employeeManager.Add();
        //}
    }


}