using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public int UserId { get; set; }
    }
}
