using AcmeVendingMachine.Server.Controllers;
using AcmeVendingMachine.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AcmeVendingMachineTest
{
    public class VendingControllerTest
    {
        private readonly Mock<VendingMachineService> _mockVendingMachineService;
        private readonly VendingMachineController _controller;

        public VendingControllerTest()
        {
            _mockVendingMachineService = new Mock<VendingMachineService>();
            _controller = new VendingMachineController(_mockVendingMachineService.Object);
        }

        [Fact]
        public void CalculateChange_ReturnsOkResult_WhenTenderAmountIsExact()
        {
            // Arrange
            var currency = "USD";
            var purchaseAmount = 1.00;
            var tenderAmount = 1.00;
            var expectedChange = new int[] { 1, 1 }; // Assuming $1 coins are returned

            _mockVendingMachineService.Setup(service => service.CalculateChange(currency, purchaseAmount, tenderAmount))
               .Returns(expectedChange);

            // Act
            var result = _controller.CalculateChange(currency, purchaseAmount, tenderAmount);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            var change = Assert.IsAssignableFrom<int[]>(okResult.Value);
            Assert.Equal(expectedChange, change);
        }

        [Fact]
        public void CalculateChange_ReturnsBadRequest_WhenInsufficientChange()
        {
            // Arrange
            var currency = "USD";
            var purchaseAmount = 1.00;
            var tenderAmount = 0.50;
            var expectedMessage = "Insufficient change available";

            _mockVendingMachineService.Setup(service => service.CalculateChange(currency, purchaseAmount, tenderAmount))
               .Throws(new InvalidOperationException(expectedMessage));

            // Act
            var result = _controller.CalculateChange(currency, purchaseAmount, tenderAmount);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            var badRequestResult = Assert.IsAssignableFrom<BadRequestObjectResult>(result);
            var message = Assert.IsAssignableFrom<string>(badRequestResult.Value);
            Assert.Equal(expectedMessage, message);
        }

        [Fact]
        public void CalculateChange_ReturnsOkResult_WhenTenderAmountIsLessThanPurchaseAmount()
        {
            // Arrange
            var currency = "USD";
            var purchaseAmount = 1.00;
            var tenderAmount = 0.50;
            var expectedMessage = "Insufficient funds provided";

            _mockVendingMachineService.Setup(service => service.CalculateChange(currency, purchaseAmount, tenderAmount))
              .Throws(new InvalidOperationException(expectedMessage));

            // Act
            var result = _controller.CalculateChange(currency, purchaseAmount, tenderAmount);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            var badRequestResult = Assert.IsAssignableFrom<BadRequestObjectResult>(result);
            var message = Assert.IsAssignableFrom<string>(badRequestResult.Value);
            Assert.Equal(expectedMessage, message);
        }

        [Fact]
        public void CalculateChange_ReturnsOkResult_WithCorrectChange_WhenCurrencyIsGBP()
        {
            // Arrange
            var currency = "GBP";
            var purchaseAmount = 1.00;
            var tenderAmount = 2.00;
            var expectedChange = new int[] { 1, 1, 1 }; // Assuming £1 coins are returned

            _mockVendingMachineService.Setup(service => service.CalculateChange(currency, purchaseAmount, tenderAmount))
              .Returns(expectedChange);

            // Act
            var result = _controller.CalculateChange(currency, purchaseAmount, tenderAmount);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            var change = Assert.IsAssignableFrom<int[]>(okResult.Value);
            Assert.Equal(expectedChange, change);
        }
    }
}