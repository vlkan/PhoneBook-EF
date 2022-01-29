using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //attribute
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        //loosely coupled - gevşek bağımlılık.
        //IoC Container -- Inversion of Control working like box. new in memory. Adressed using which class
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<Customer> Get() {
            var result = _customerService.GetAll();
            return result.Data;
        }
    }
}
