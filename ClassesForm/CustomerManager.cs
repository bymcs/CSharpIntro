using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForm
{
    internal class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                    new Customer() { Id=1, FirstName="Mehmet Can", LastName="Şahin", City="Bilecik", Email="mcs@mail.com" },
                    new Customer() { Id=2, FirstName="Can", LastName="Yılmaz", City="İstanbul", Email="can@mail.com" },
                    new Customer() { Id=3, FirstName="Ayşe", LastName="Kara", City="Ankara", Email="aysekara@mail.com" },
                    new Customer() { Id=4, FirstName="Ali", LastName="Demir", City="İzmir", Email="ali.demir@mail.com" },
                    new Customer() { Id=5, FirstName="Fatma", LastName="Koç", City="Adana", Email="fatma.koc@mail.com" },
                    new Customer() { Id=6, FirstName="Emre", LastName="Aydın", City="İstanbul", Email="emre.aydin@mail.com" },
                    new Customer() { Id=7, FirstName="Seda", LastName="Yıldız", City="Antalya", Email="seda.yildiz@mail.com" },
                    new Customer() { Id=8, FirstName="Cem", LastName="Öztürk", City="Eskişehir", Email="cem.ozturk@mail.com" },
                    new Customer() { Id=9, FirstName="Feyza", LastName="Kılıç", City="Konya", Email="feyza.kilic@mail.com" },
                    new Customer() { Id=10, FirstName="Murat", LastName="Köse", City="Denizli", Email="murat.kose@mail.com" }
            };
        }

        List<Customer> customers;

        public List<Customer> GetAll()
        {
            return customers;
        } 

        public void Add(Customer customer)
        { 
            customers.Add(customer);
        }
    }
}
