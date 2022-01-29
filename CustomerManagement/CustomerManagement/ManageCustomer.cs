using System;
using Orders;

namespace CustomerManagement
{
    class ManageCustomer
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine(order.viewOrder("Customer Management System"));
            Console.WriteLine(order.resolveOrder());

        }
    }
}