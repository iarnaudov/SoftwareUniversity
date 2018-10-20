using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public abstract class Order : IOrder
    {
        public abstract void Execute();
    }
}
