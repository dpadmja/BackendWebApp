using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Products.Services.ServiceModels
{
  public  class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "username";
        public string Password { get; set; } = "password";
    }
}
