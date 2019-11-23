using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MyProduct.Domain.Entities;

namespace MyProduct.DataAccess.EntityContext
{
    public partial class ProductContext    
    {

        public virtual DbSet<Product> Products { get; set; }

    }
}
