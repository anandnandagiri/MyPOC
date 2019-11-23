using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProduct.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryID { get; set; }

        public int SupplierID { get; set; }
        
    }
}
