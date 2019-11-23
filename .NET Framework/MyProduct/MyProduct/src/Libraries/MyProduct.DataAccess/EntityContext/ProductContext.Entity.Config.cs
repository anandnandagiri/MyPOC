using MyProduct.DataAccess.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MyProduct.DataAccess.EntityContext
{
    public partial class ProductContext : BaseContext
    {
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {

            // To remove the requests to the Migration History table
            Database.SetInitializer<ProductContext>(null);
            // To remove the plural names   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductConfig());            
        }
    }
}
