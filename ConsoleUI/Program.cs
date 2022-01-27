using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer1 = new CustomerManager(new EfCustomerDal());

            foreach (var customer in customer1.GetAllByCustomerName("Volkan"))
            {
                Console.WriteLine(customer.CustomerName);
            }
        }
    }
}