namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello, World!");

            PersonManager personManager = new PersonManager();
            personManager.Add();

            CustomerManager customerManager = new CustomerManager();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.GetBestEmployee();
         
        }
    }


    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("ADD");
        }

        public void Update()
        {
            Console.WriteLine("UPDATE");
        }
    }

    class CustomerManager : PersonManager
    {
        public void GetBestCustomer()
        {

        }
    }

    class EmployeeManager : PersonManager
    {
        public void GetBestEmployee()
        {

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }

    class Customer
    {
        public string CreditCardNumber { get; set; }
    }




}