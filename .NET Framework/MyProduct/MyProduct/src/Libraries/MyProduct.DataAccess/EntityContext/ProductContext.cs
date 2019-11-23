using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProduct.DataAccess.EntityContext
{
    public partial class ProductContext : BaseContext
    {
        public ProductContext()
            : base("name=SQLDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}
