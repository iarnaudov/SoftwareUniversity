using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public class BuyStock : Order
    {
       private Stock currencyStock;

        public BuyStock(Stock abcStock)
        {
            this.currencyStock = abcStock;
        }

        public override void Execute()
        {
            currencyStock.Buy();
        }
    }
}
