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
    public class UserController : ControllerBase
    {
        private UserDomain UserDomain { get; set; }
        public UserController()
        {
            this.UserDomain = new UserDomain();
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            var isLoggedIn = this.UserDomain.IsLogin(user);
            return Ok(isLoggedIn);
        }
    }
}
