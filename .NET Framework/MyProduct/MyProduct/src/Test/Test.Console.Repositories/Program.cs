using MyProduct.Domain.Entities;
using MyProduct.DataAccess.EntityContext;
using MyProduct.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyProduct.Business.Services;
using MyProduct.Business.Contracts.Services;


namespace Test.Console.Repositories
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cnnString = ConfigurationManager.ConnectionStrings["MongoDBContext"].ConnectionString;

            //ProductContext cnt = new ProductContext();
            //ProductRepository rep = new ProductRepository(cnt);
            //var pt = rep.GetProducts();
            //Product p = new Product();
            //p.ProductID = 1;
            //p.CategoryID = 1;            
            //p.ProductName = "test";
            //p.SupplierID = 1;
            //p.UnitPrice = 10;
            //rep.Add(p);
            ////Concerrency Mode
            //rep.ProductContext.Entry(p).State = EntityState.Added;
            //rep.ProductContext.SaveChanges();

            IProductService service = new ProductService();
            var product = service.GetProductByID(101);
            


        }
    }
}
