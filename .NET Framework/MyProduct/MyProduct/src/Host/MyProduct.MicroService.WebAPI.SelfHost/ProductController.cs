using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MyProduct.WebApi.Core;
using MyProduct.Domain.Entities;
using MyProduct.Business.Contracts.Services;
using MyProduct.Business.Services;

namespace MyProduct.MicroService.WebAPI.SelfHost
{
    public class ProductController : BaseController
    {
        IProductService service;
        
        public ProductController()
        {
            service = new ProductService();
        }

        [HttpGet]
        //api/product/GetProducts
        public IEnumerable<Product> GetProductList()
        {
            return service.GetAllProduct();
        }

        public Product GetOneProduct()
        {
            Product p =  service.GetAllProduct().FirstOrDefault();
            return p;
        }


        [HttpGet]
        //api/product/GetProducts
        public ApiResponse<IEnumerable<Product>> GetProducts()
        {
            return ComposeResponse<IEnumerable<Product>>(()=> service.GetAllProduct());
        }


        [HttpGet]
        //api/product/GetProductByID?productID=101
        public ApiResponse<Product> GetProductByID(int productID)
        {
            return ComposeResponse<Product>(() => service.GetProductByID(productID));            
        }


        [HttpGet]
        //api/product/RemoveProduct?productID=1
        public ApiResponse<bool> RemoveProduct(int productID)
        {
            return ComposeResponse<bool>(() => service.RemoveProductByID(productID));
        } 

        [HttpPost]
        public void AddProduct(Product product)
        {
            service.AddProduct(product);
        }


        [HttpGet]
        //api/product/ProductByIDTest
        public string ProductByIDTest()
        {
            return "Shalini Lakshmi Bayama";
        }

    }
}
