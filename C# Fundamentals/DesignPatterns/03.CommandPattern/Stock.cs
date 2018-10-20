using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public class Stock
    {

        private readonly string name = "EUR/USD";
        private readonly int quantity = 100;

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity + " ] bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ",  Quantity: " + quantity + " ] sold");
        }
    }
}
