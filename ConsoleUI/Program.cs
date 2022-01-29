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

            var result = customer1.GetAllByCustomerSearch("Volka");

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CustomerName + " / " + customer.CustomerPhoneNumber);
                }
            }
            else { 
                Console.WriteLine(result.Message);
            }

            
        }
    }
}