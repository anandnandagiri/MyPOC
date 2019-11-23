using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using MyProduct.Domain.Entities;
using MyProduct.DataAccess.EntityContext;
using MyProduct.Repositories;
using System.Collections.Generic;

namespace Test.Product.DataAccess.Repositories
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var cnnString = ConfigurationManager.ConnectionStrings["MongoDBContext"].ConnectionString;

            ProductContext cnt = new ProductContext();
            ProductRepository rep = new ProductRepository(cnt);
            var pt = rep.GetProducts();



            Assert.Inconclusive(cnnString);
        }
    }
}
