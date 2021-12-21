using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Data.SqlClient;

namespace TravisB_P0
{
    public class Order : IOrder
    {
        private List<Product>? ShoppingCart;
        private DateTime? OrderDate;
        Locations location;

        //constructors
        public Order(List<Product> cart, Locations location)
        {
            this.ShoppingCart = cart;
            this.location = location;
        }

        public void AddToCart(Order order, Product selection)
        {
            ShoppingCart!.Add(selection);
        }
        public void FinalizeOrder(Order order, Customer customer)
        {
            this.OrderDate = DateTime.Now;

        }

        public void AddToHistory(Order order)
        {

        }

        public float Total(List<Product> cart)
        {
            foreach (Product item in ShoppingCart!)
            {
                int total = 0;
                return total;
            }
            return 0;
        }
    }
}