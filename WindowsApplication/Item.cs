using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication
{
    internal class Item
    {
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        protected double totalPrice;

        public Item(string name, double price, int quantity)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = quantity;
            totalPrice = price * quantity;
        }

        public double getTotalPrice()
        {
            return totalPrice;
        }

        public void setPayment(double amount)
        {
            
        }
    }
}

