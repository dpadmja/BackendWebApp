using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Products.Services.ServiceModels;

namespace Products.Services
{
    public class ProductAuthenticateService : IProductAuthenticationService
    {
        public ProductAuthenticateService()
        { }
        public async Task<User> Authenticate(string username, string password)
        {
            if (username == "username" && password == "password")
            {
                var user = new User() { Id = 1, Password = "Password", UserName = "SomeUserName" };
                return user;
            }

            return null;
        }
    }
}
