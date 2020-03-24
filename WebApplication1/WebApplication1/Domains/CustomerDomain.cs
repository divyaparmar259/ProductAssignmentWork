using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Domains
{
    public class CustomerDomain : BaseDomain
    {
        public void CustomerAdd(Customer customer)
        {
            this.ExecuteNonQuery($"insert into Customers(CustomerName,CustomerPassword) values('{customer.CustomerName}','{customer.CustomerPassword}')");

        }
        public int IsLogin(Customer customer)
        {
            var reader = this.GetReader($"select * from Customers where CustomerName='{customer.CustomerName}' and CustomerPassword='{customer.CustomerPassword}'");
            var IsLoggedIn = 0;
            while (reader.Read())
            {
                IsLoggedIn = 1;
            }
            return IsLoggedIn;
        }

      
        }
}
