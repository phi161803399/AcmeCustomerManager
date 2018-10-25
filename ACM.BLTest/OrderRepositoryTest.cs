using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

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

            Console.WriteLine("Order: " + expected.ToString());

            // Actual
            var actual = orderRepository.Retrieve(10);

            // Arrange
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        
        }
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2018, 10, 19, 10, 00, 00, new TimeSpan(2, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6M,
                        OrderQuantity = 1
                    }
                }
            };

            // Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            // Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            // etc etc etc...
        }
    }
}
