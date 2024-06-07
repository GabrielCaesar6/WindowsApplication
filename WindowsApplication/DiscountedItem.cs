using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication
{
    internal class DiscountedItem : Item
    {
        private double itemDiscount;
        private double discountedPrice;
        private double paymentAmount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            itemDiscount = discount;
            discountedPrice = price * (1 - discount * 0.01);
            totalPrice = discountedPrice * quantity;
        }

        public new double getTotalPrice()
        {
            return totalPrice;
        }

        public void setPayment(double amount)
        {
            paymentAmount = amount;
            change = amount - totalPrice;
        }

        public double getChange()
        {
            return change;
        }
    }
}
