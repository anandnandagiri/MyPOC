using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct.Domain.Entities;

namespace MyProduct.Business.Contracts.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID();
        bool RemoveProduct(int productID);
        bool AddProduct(Product product);
        
        Task<IEnumerable<Product>> GetProductsAsyn();
        Task<Product> GetProductByIDAsyn();
    }
}
