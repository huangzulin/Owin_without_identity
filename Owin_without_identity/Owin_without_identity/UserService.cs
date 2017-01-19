using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Owin_without_identity
{
    public class UserService
    {
        public User Authenticate(string username, string password)
        {
            var user = new User()
            {
                Name = "huangzulin",
                Email = "huangzl@qq.com"

            };
            return user;
        }
    }


    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Role> Roles { get; set; }
    }


    public class Role
    {
        public string TechnicalName { get; set; }

    }
}