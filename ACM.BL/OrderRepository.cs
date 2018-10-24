using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// retrieve one Order by id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 10, 19, 10, 00, 00, new TimeSpan(2, 0, 0));
            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            // Code that retrieves the defined order fields
            // Temporary Hard-coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 10, 19, 10, 00, 00, new TimeSpan(2, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
            // Code that retrieves the order items
            // Temporary Hard-coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }

        public bool Save()
        {
            // code that saves current order
            return true;
        }
    }
}
