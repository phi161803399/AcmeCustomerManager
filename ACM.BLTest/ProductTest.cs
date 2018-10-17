using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Product product = new Product();
            product.ProductName = "Ring";
            product.CurrentPrice = 10;
            var expected = true;

            // Act
            var actual = product.Validate();

            // Arramge
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingProductName()
        {
            // Arrange
            Product product = new Product();
            product.CurrentPrice = 10;
            var expected = false;

            // Act
            var actual = product.Validate();

            // Arramge
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice()
        {
            // Arrange
            Product product = new Product();
            product.ProductName = "Ring";
            var expected = false;

            // Act
            var actual = product.Validate();

            // Arramge
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPriceAndProductName()
        {
            // Arrange
            Product product = new Product();
            var expected = false;

            // Act
            var actual = product.Validate();

            // Arramge
            Assert.AreEqual(expected, actual);
        }
    }
}
