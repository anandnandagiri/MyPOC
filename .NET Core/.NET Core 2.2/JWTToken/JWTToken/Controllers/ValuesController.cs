using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTToken.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private AppIdentityDbContext context;

        public ValuesController(AppIdentityDbContext context)
        {
            this.context = context;            
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return context.Users.Select(u => u.UserName).ToArray();
        }        
    }
}
