using System;


namespace OrderDetails
{
    internal class Items
    {
        public string setItemName(string itemName)
        {
            return "item: " + itemName;
        }

        public string setItemPrice(double price)
        {
            return price.ToString();
        }
    }
}