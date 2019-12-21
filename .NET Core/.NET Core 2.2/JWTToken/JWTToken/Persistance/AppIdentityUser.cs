using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTToken.Persistance
{
    public class AppIdentityUser : IdentityUser
    {
        public string myteststring { get; set; }
    }
}
