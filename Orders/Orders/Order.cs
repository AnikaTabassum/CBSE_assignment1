using System;
using OrderDetails;

namespace Orders
{
    public class Order
    {
        OrderDetail detailedOrder = new OrderDetail();
 
        public string viewOrder(string user)
        {
            return "User "+ user +"/n"+detailedOrder.getOrderDetails();
            
        }

        public string resolveOrder()
        { 
            return "Order " + detailedOrder.getOrderDetails() + " is resolved";

        }
    }
}