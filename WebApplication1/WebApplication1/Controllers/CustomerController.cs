using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Domains;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        
        private CustomerDomain CustomerDomain { get; set; }
        public CustomerController()
        {
            this.CustomerDomain = new CustomerDomain();
        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            var isLoggedIn = this.CustomerDomain.IsLogin(customer);
            return Ok(isLoggedIn);
        }

      
    }
}
