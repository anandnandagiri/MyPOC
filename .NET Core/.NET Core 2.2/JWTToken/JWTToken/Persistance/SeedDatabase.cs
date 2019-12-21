using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTToken.Persistance
{
    public class SeedDatabase
    {
        public static void SeedData(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppIdentityDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppIdentityUser>>();

            context.Database.EnsureCreated();

            if(!context.Users.Any())
            {
                AppIdentityUser user = new AppIdentityUser()
                {
                    UserName = "Anand",                   
                    Email = "pavan.anand.n@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                userManager.CreateAsync(user, "pwd@123");
            }

        }
    }
}
