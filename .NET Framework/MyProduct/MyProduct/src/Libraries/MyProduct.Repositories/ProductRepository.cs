using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct.Domain.Entities;
using MyProduct.DataAccess.EntityContext;
using MyProduct.Business.Contracts.Repositories;


namespace MyProduct.Repositories
{
    public class ProductRepository :  BaseRepository<Product>, IProductRepository
    {

        public ProductRepository() : base(new ProductContext())
        {
        }

        public ProductRepository(ProductContext context) : base(context)
        {
        }

        public ProductContext ProductContext
        {
            get
            {
                return Context as ProductContext;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
           return this.GetAll();
        }

        public bool RemoveProduct(int productID)
        {
            Product product = this.GetByID(productID);
            if(product != null)
            {
                this.Remove(product);
                this.ProductContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<IEnumerable<Product>> GetProductsAsyn()
        {
            throw new NotImplementedException();
        }
        
        public Product GetProductByID()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIDAsyn()
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Product product)
        {
            try
            {
                this.Add(product);
                this.ProductContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
