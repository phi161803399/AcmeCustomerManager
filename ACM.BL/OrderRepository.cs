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

        public bool Save()
        {
            // code that saves current order
            return true;
        }
    }
}
