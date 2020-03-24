using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;
using WebApplication1.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerAddController : ControllerBase
    {
        private CustomerDomain CustomerDomain { get; set; }
        public CustomerAddController()
        {
            this.CustomerDomain = new CustomerDomain();
        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            this.CustomerDomain.CustomerAdd(customer);
            return Ok();
        }
    }
}
