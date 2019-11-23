using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct.Domain.Entities;

namespace MyProduct.Business.Contracts.Services
{
    public interface IProductService
    {
        Product GetProductByID(int productID);
        IEnumerable<Product> GetAllProduct();
        bool RemoveProductByID(int productID);
        bool AddProduct(Product product);
    }
}
