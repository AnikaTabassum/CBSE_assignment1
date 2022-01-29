using System;
using Orders; 

namespace KitchenManagementSystem
{
    class ManageKitchen
    {
        static void Main(string[] args)
        {
            Order order = new Order(); 

            Console.WriteLine(order.viewOrder("Kitchen Management System"));
            Console.WriteLine(order.resolveOrder());

        }
    }
}