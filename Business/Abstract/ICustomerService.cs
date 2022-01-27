using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetAllByCustomerName(string name);
        List<Customer> GetAllByCustomerPhoneNumber(string number);
        List<Customer> GetAllByCustomerSearch(string search);

        IResult Add(Customer customer);
    }
}
