using System;

namespace _03.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock currencyStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(currencyStock);
            SellStock sellStockOrder = new SellStock(currencyStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
