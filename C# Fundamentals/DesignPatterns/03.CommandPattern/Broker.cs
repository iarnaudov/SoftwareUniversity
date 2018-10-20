using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {

            foreach (Order order in orderList)
            {
                order.Execute();
            }
            orderList.Clear();
        }
    }
}
