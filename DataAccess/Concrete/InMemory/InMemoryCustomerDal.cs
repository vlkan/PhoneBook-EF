using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;

        public InMemoryCustomerDal()
        {
            _customers = new List<Customer> { 
                new Customer {Id = 1}
            };
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);  
        }

        public void Delete(Customer customer)
        {
            Customer customerToDelete = _customers.SingleOrDefault(c => c.Id == customer.Id);
            _customers.Remove(customerToDelete);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllByCustomerName(string CustomerName)
        {
            return _customers.Where(c=>c.CustomerName == CustomerName).ToList();
        }

        public List<Customer> GetAllByCustomerPhoneNumber(string CustomerPhoneNumber)
        {
            return _customers.Where(c=>c.CustomerPhoneNumber == CustomerPhoneNumber).ToList();
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = _customers.SingleOrDefault(c => c.Id == customer.Id);
            customerToUpdate.Id = customer.Id;
        }
    }
}
