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
        //Volkan ÖNDER
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _customerService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("search")]
        public IActionResult Search(string search) {
            var result = _customerService.GetAllByCustomerSearch(search);
            if (result.Success) {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer) 
        {
            var result = _customerService.Add(customer);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
