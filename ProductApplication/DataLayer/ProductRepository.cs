using DomainModels;
using SomeThirdPartyDbAccessThing.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductRepository
    {

        //------------------------------------------------1st iteration
        //public Product GetProductById(int productId)
        //{
        //    return new Product { Id = productId };
        //}


        //------------------------------------------------2nd iteration
        //IDbAccess dbAccess;

        //public ProductRepository(IDbAccess dbAccess)
        //{
        //    this.dbAccess = dbAccess;
        //}

        //public Product GetProductById(int productId)
        //{
        //    dbAccess.ExecuteStoredProcedure("Get_Product_By_Id", null);
        //    return new Product { Id = productId };
        //}


        //------------------------------------------------3rd iteration
        //IDbAccess dbAccess;

        //public ProductRepository(IDbAccess dbAccess)
        //{
        //    this.dbAccess = dbAccess;
        //}

        //public Product GetProductById(int productId)
        //{
        //    var parameters = new Dictionary<string, object> {
        //        { "ProductId", productId }
        //    };
        //    dbAccess.ExecuteStoredProcedure("Get_Product_By_Id", parameters);
        //    return new Product { Id = productId };
        //}


        //------------------------------------------------4th iteration
        //private IDbAccess dbAccessMock;
        //
        //public ProductRepository(IDbAccess dbAccessMock)
        //{
        //    this.dbAccessMock = dbAccessMock;
        //}
        //
        //public Product GetProductById(int productId)
        //{
        //    var parameters = new Dictionary<string, object> {
        //        { "ProductId", productId }
        //    };
        //    var productDataTable = dbAccessMock.ExecuteStoredProcedure("Get_Product_By_Id", parameters);
        //    Product product = null;
        //    if (productDataTable != null && productDataTable.Rows.Count > 0)
        //    {
        //        var firstRow = productDataTable.Rows[0];
        //        product = new Product
        //        {
        //            Id = (int)firstRow["Id"],
        //            Name = (string)firstRow["Name"],
        //            ArticleNr = (int)firstRow["ArticleNr"],
        //            Price = (int)firstRow["Price"]
        //        };
        //    }
        //    return product;
        //}

    }
}
