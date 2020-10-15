using System.Linq;
using BackendWebApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Products.Repository;
using Products.Services;

namespace Products.UnitTests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void TestGetProducts_Success()
        {
            Mock<IProductsService> productService = new Mock<IProductsService>();
            Mock<ProductsDbContext> productRepo = new Mock<ProductsDbContext>();
            CompanyProductsController productsController = new CompanyProductsController(productRepo.Object, productService.Object);
            var actualProducts = productsController.GetProducts();
            Assert.AreEqual(0, actualProducts.Count());

        }
    }
}
