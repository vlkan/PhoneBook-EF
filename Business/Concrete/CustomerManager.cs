using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        //Volkan ÖNDER

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.SuccessToList);
        }

        public IDataResult<List<Customer>> GetAllByCustomerName(string name)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerName == name));
        }

        public IDataResult<List<Customer>> GetAllByCustomerPhoneNumber(string number)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerPhoneNumber == number));
        }

        public IDataResult<List<Customer>> GetAllByCustomerSearch(string search)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerPhoneNumber == search || c.CustomerName == search));
        }
    }
}
