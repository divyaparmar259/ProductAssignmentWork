using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Domains
{
    public class UserDomain : BaseDomain
    {
        public void UserAdd(User user)
        {
            this.ExecuteNonQuery($"insert into Users(UserName,UserPassword) values('{user.UserName}','{user.UserPassword}')");

        }
        public int IsLogin(User user)
        {
            var reader = this.GetReader($"select * from Users where UserName='{user.UserName}' and UserPassword='{user.UserPassword}'");
            var IsLoggedIn = 0;
            while (reader.Read())
            {
                IsLoggedIn = 1;
            }
            return IsLoggedIn;
        }
    }
}
