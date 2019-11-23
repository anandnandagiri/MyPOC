using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct.Domain.Entities;
using MyProduct.Repositories;
using MyProduct.Business.Contracts.Services;
using MyProduct.Business.Contracts.Repositories;



namespace MyProduct.Business.Services
{
    public class ProductService : IProductService
    {
        IProductRepository repo;

        public ProductService()
        {
            repo = new ProductRepository();
        }
        
        public Product GetProductByID(int productID)
        {
            return repo.GetProductByID();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return repo.GetProducts();
        }
        
        public bool RemoveProductByID(int productID)
        {
            return repo.RemoveProduct(productID);           
        }

        public bool AddProduct(Product product)
        {
            return repo.AddProduct(product);
        }
    }
}
