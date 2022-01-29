using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    public class OrderDetail
    {
        public string getOrderDetails()
        {
            Items items = new Items();
            return items.setItemName("Bhaat") + " with price " + items.setItemPrice(5.99);
        }
    }
}
