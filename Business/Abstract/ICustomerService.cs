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
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCustomerName(string name);
        IDataResult<List<Customer>> GetAllByCustomerPhoneNumber(string number);
        IDataResult<List<Customer>> GetAllByCustomerSearch(string search);

        IResult Add(Customer customer);
        IResult Delete(Customer customer);
    }
}
