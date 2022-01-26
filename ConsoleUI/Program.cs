﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer1 = new CustomerManager(new InMemoryCustomerDal());

            foreach (var customer in customer1.GetAll())
            {
                Console.WriteLine(customer.Id);
            }
        }
    }
}