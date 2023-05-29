using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Controllers;

namespace WebApplications3.tests
{
    public class CheckoutServiceTest
    {
        [Fact]
        public void CalculateTotalPrice_EmptySKUs_ReturnsZero()
        {
            // Arrange
            var checkoutService = new CheckoutService();

            // Act
            decimal totalPrice = checkoutService.CalculateTotalPrice("");

            // Assert
            Assert.Equal(0, totalPrice);
        }
        [Fact]
        public void CalculateTotalPrice_SingleSKU_ReturnsCorrectPrice()
        {
            // Arrange
            var checkoutService = new CheckoutService();

            // Act
            decimal totalPrice = checkoutService.CalculateTotalPrice("A");

            // Assert
            Assert.Equal(50, totalPrice);
        }
        [Fact]
        public void CalculateTotalPrice_MultipleSKUs_ReturnsCorrectPrice()
        {
            // Arrange
            var checkoutService = new CheckoutService();

            // Act
            decimal totalPrice = checkoutService.CalculateTotalPrice("AB");

            // Assert
            Assert.Equal(80, totalPrice);
        }
    }
}
