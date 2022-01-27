using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetAllByCustomerName(string name)
        {
            return _customerDal.GetAll(c => c.CustomerName == name);
        }

        public List<Customer> GetAllByCustomerPhoneNumber(string number)
        {
            return _customerDal.GetAll(c => c.CustomerPhoneNumber == number);
        }

        public List<Customer> GetAllByCustomerSearch(string search)
        {
            return _customerDal.GetAll(c => c.CustomerPhoneNumber == search || c.CustomerName == search);
        }
    }
}
