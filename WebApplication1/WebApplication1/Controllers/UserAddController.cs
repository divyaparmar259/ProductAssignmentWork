using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;
using WebApplication1.Models;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAddController : ControllerBase
    {
        private UserDomain UserDomain { get; set; }
        public UserAddController()
        {
            this.UserDomain = new UserDomain();
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            this.UserDomain.UserAdd(user);
            return Ok();
        }
    }
}
