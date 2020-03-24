using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Domains
{
    public class ProductDomain : BaseDomain
    {
        public void ProductAdd(Product product)
        {
            this.ExecuteNonQuery($"insert into Products(ProductName,ProductPrice,ProductQuantity,UserId) values ('{product.ProductName}','{product.ProductPrice}','{product.ProductQuantity}','{product.UserId}')");

        }
         public List<Product> Get(int userId)
       {
           var reader = this.GetReader($"select ProductName from Products where UserId ={userId} ");
           var products = new List<Product>();
           while (reader.Read())
           {
               var product = new Product();
                product.ProductName = reader.GetString(2);

               products.Add(product);
           }
           return products;

       }

    }
}
