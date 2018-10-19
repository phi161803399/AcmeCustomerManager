using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 10, 19, 10, 00, 00, new TimeSpan(2, 0, 0))
            };

            // Actual
            var actual = orderRepository.Retrieve(10);

            // Arrange
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        
        }
    }
}
