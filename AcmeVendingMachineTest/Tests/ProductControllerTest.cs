using AcmeVendingMachine.Server.Controllers;
using AcmeVendingMachine.Server.Model;
using AcmeVendingMachine.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AcmeVendingMachineTest.Tests
{
    public class ProductControllerTest
    {
        private readonly Mock<ProductService> _mockProductsService;
        private readonly ProductController _controller;
        public ProductControllerTest()
        {
            _mockProductsService = new Mock<ProductService>();
            _controller = new ProductController(_mockProductsService.Object);
        }

        [Fact]
        public void GetProducts_ReturnsOkResult_WhenCalled()
        {
            // Arrange
            var products = new List<Product> { new Product { Id = "1", Name = "CocaCola" } };
            _mockProductsService.Setup(service => service.GetAllProducts()).Returns(products);

            // Act
            var result = _controller.GetProducts();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
            Assert.Equal(products, model);
        }

        [Fact]
        public void GetProductById_ReturnsOkResult_WhenCalled()
        {
            // Arrange
            var product = new Product { Id = "1", Name = "CocaCola" };
            _mockProductsService.Setup(service => service.GetProductById("1")).Returns(product);

            // Act
            var result = _controller.GetProductById("1");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<Product>(okResult.Value);
            Assert.Equal(product, model);
        }
    }
}