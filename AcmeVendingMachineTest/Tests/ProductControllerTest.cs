using AcmeVendingMachine.Server.Controllers;
using AcmeVendingMachine.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcmeVendingMachineTest.Tests
{
    public class ProductControllerTest
    {
        Product product;
        ProductService productService;
        public ProductControllerTest()
        {
            productService = new ProductService();
            product = new Product(productService);
        }

        [Fact]
        public void GetAllProducts()
        {
            //Arrange
            //Act
            var result = product.GetProducts();
            //Assert
            Assert.IsType<OkObjectResult>(result);

            var list = result as OkObjectResult;

            //Assert.IsType<List<Product>>(list.Value);



            //var listBooks = list.Value as List<Product>;

            //Assert.Equal(5, listBooks.Count);
        }
    }
}