using System;
using System.Collections.Generic;
namespace CommandPatternDemo
{
    public class Waitress
    {
        private List<Order> orders;

        public Waitress()
        {
            orders = new List<Order>();
        }

        public void TakeOrder(Order order){
            orders.Add(order);
        }

        public void PlaceOrder()
        {
            foreach(Order order in orders){
                order.Cook();
            }

            orders.Clear();
        }
    }
}
