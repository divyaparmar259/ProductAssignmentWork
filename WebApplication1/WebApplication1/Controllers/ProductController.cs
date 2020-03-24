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
    public class ProductController : ControllerBase
    {
        private ProductDomain ProductDomain { get; set; }
        public ProductController()
        {
            this.ProductDomain = new ProductDomain();
        }
        [HttpPost]
        public IActionResult Post (Product product)
        {
            this.ProductDomain.ProductAdd(product);
              return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product1 = this.ProductDomain.Get(id);
            return Ok(product1);
        }
    }
}
