using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MyProduct.DataAccess.EntityContext
{
    public class BaseContext : DbContext
    {
        public BaseContext()
            : base()
        {
        }
        public BaseContext(string dbname)
            : base(dbname)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
