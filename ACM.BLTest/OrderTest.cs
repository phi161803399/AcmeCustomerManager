using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Order order = new Order();
            order.OrderDate = new DateTime(2018, 10, 17);
            var expected = true;

            // Act
            var actual = order.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingOrderdate()
        {
            // Arrange
            Order order = new Order();
            order.OrderDate = null;
            var expected = false;

            // Act
            var actual = order.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
