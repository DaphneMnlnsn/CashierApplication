﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    internal class DiscountedItem: Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        public double change;

        public DiscountedItem(string name, double price, int quantity, double discount): base(name, price, quantity)
        {
            this.item_discount = discount * 0.01;
            this.discounted_price = price - (item_discount * item_price);
        }

        public override double getTotalPrice()
        {
            total_price = discounted_price * item_quantity;
            return total_price;
        }
        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }
        public double getChange()
        {
            this.change = payment_amount - getTotalPrice();
            return this.change;
        }

    }
}
