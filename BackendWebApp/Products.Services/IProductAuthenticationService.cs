using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Products.Services.ServiceModels;

namespace Products.Services
{
    public interface IProductAuthenticationService
    {
         Task<User> Authenticate(string username, string password);
    }
}
