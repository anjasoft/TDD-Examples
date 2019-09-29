using DataLayer.Tests.Mocks;
using DomainModels;
using NUnit.Framework;
using SomeThirdPartyDbAccessThing.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tests
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        //------------------------------------------------1st iteration: getting a product by id
        //We know that we want the ProductRepository to be able to return a single Product if we provide that product's ID. 
        //So we make sure that it can do it by first adding a test that makes sure we get a product back and that the product has the same ID as we provided.

        //[Test]
        //public void  CanGetProductById()
        //{
        //    var productId = 123;
        //    var productsRepository = new ProductRepository();
        //    var product = productsRepository.GetProductById(productId);
        //    Assert.AreEqual(productId, product.Id);
        //}


        //------------------------------------------------2nd iteration: Ensuring repository calls the db access
        //When we know that the ProductRepository can return a product, we want to test the behaviour: asserting that it is calling the DbAccess layer.
        //To do that we need to introduce a mock of IDbAccess. In this simple example we are using our own mock, but one would probably use a mocking framework in a real world scenario
        //After adding a test for that and some refactoring, we'll end up with this.

        //ProductRepository productsRepository;
        //ProductDbAccessMock dbAccessMock;
        //Product actualProduct;
        //int productId;

        //[SetUp]
        //public void SetUp()
        //{
        //    productId = 123;
        //    dbAccessMock = new ProductDbAccessMock();
        //    productsRepository = new ProductRepository((IDbAccess)dbAccessMock);
        //    actualProduct = productsRepository.GetProductById(productId);
        //}

        //[Test]
        //public void  CanGetProductById()
        //{
        //    Assert.AreEqual(productId, actualProduct.Id);
        //}

        //[Test]
        //public void GetProductById_CallsDbAccess()
        //{
        //    Assert.IsTrue(dbAccessMock.ExecuteProcedureWasCalled);
        //}


        //------------------------------------------------3rd iteration: Ensuring repository passes parameters to the procedure/dbAccess layer
        //It's not enough to make sure that the DbAccess is called, we need to also make sure that we are passing a ProductID to the stored procedure. So we add a test for that as well.



        //ProductRepository productsRepository;
        //ProductDbAccessMock dbAccessMock;
        //Product actualProduct;
        //int productId;

        //[SetUp]
        //public void SetUp()
        //{
        //    productId = 123;
        //    dbAccessMock = new ProductDbAccessMock();
        //    productsRepository = new ProductRepository((IDbAccess)dbAccessMock);
        //    actualProduct = productsRepository.GetProductById(productId);
        //}

        //[Test]
        //public void CanGetProductById()
        //{
        //    Assert.AreEqual(productId, actualProduct.Id);
        //}

        //[Test]
        //public void GetProductById_CallsDbAccess()
        //{
        //    Assert.IsTrue(dbAccessMock.ExecuteProcedureWasCalled);
        //}

        //[Test]
        //public void GetProductById_PassesProductIdParameter()
        //{
        //    var actualProductId = dbAccessMock.PassedParameters["ProductId"];
        //    Assert.AreEqual(productId, actualProductId);
        //}

        //------------------------------------------------4th iteration: getting rid of our hard coded object
        //So far it seems that everything is working nicely. But we are still relying on that hard coded product, with only an ID. That wont work for long.
        //If we could somehow control what the DbAccess is returning, we could make sure that we get back what we want without it being hard coded in the repository.
        //The beauty of mocks is that we can!
        //In this last step we set up an expectedProduct, and alters the first test to check that the returned, actual product is the same as the one we expect. We then create a DataTable containing our expectedProduct, and tell our mock that this is the one we want to return.

        //ProductRepository productsRepository;
        //ProductDbAccessMock dbAccessMock;
        //Product actualProduct;
        //Product expectedProduct;

        //[SetUp]
        //public void SetUp()
        //{
        //    expectedProduct = CreateExpectedProduct();
        //    dbAccessMock = new ProductDbAccessMock();
        //    dbAccessMock.ToReturnDataTable = CreateProductDataTable(expectedProduct);
        //    productsRepository = new ProductRepository((IDbAccess)dbAccessMock);
        //    actualProduct = productsRepository.GetProductById(expectedProduct.Id);
        //}

        //[Test]
        //public void CanGetProductById()
        //{
        //    Assert.AreEqual(expectedProduct, actualProduct);
        //}

        //[Test]
        //public void GetProductById_CallsDbAccess()
        //{
        //    Assert.IsTrue(dbAccessMock.ExecuteProcedureWasCalled);
        //}

        //[Test]
        //public void GetProductById_PassesProductIdParameter()
        //{
        //    var actualProductId = dbAccessMock.PassedParameters["ProductId"];
        //    Assert.AreEqual(expectedProduct.Id, actualProductId);
        //}

        //private Product CreateExpectedProduct()
        //{
        //    Random rand = new Random();
        //    return new Product
        //    {
        //        Id = rand.Next(1,100),
        //        Name = "TestProduct_"+rand.Next(1,10),
        //        ArticleNr = rand.Next(1, 1000000),
        //        Price = rand.Next(1, 1000)
        //    };
        //}

        //private DataTable CreateProductDataTable(Product product)
        //{
        //    DataTable dt = new DataTable("Product");
        //    dt.Columns.Add(new DataColumn("Id", typeof(int)));
        //    dt.Columns.Add(new DataColumn("Name", typeof(string)));
        //    dt.Columns.Add(new DataColumn("ArticleNr", typeof(int)));
        //    dt.Columns.Add(new DataColumn("Price", typeof(int)));

        //    DataRow dr = dt.NewRow();
        //    dr["Id"] = product.Id;
        //    dr["Name"] = product.Name;
        //    dr["ArticleNr"] = product.ArticleNr;
        //    dr["Price"] = product.Price;

        //    dt.Rows.Add(dr);

        //    return dt;

        //}


    }
}
