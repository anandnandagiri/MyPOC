using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTToken.Persistance
{
    public class AppIdentityDbContext: IdentityDbContext<AppIdentityUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region "Seed Data"

            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
            );

            builder.Entity<AppIdentityUser>().HasData(
            new
            {
                Id = "1",
                UserName = "Anand",
                Email = "pavan.anand.n@gmail.com",
                SecurityStamp = Guid.NewGuid().ToString(),
                AccessFailedCount = 1,
                EmailConfirmed = true,
                LockoutEnabled = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false
            });

            //this.Database.EnsureCreated();

            #endregion
        }
    }
}
