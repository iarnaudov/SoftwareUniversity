using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public class SellStock : Order
    {
       private Stock currencyStock;

        public SellStock(Stock abcStock)
        {
            this.currencyStock = abcStock;
        }

        public override void Execute()
        {
            currencyStock.Sell();
        }
    }
}
