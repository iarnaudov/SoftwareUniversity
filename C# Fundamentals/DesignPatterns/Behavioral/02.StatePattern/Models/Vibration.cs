using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Vibration : IMobileAlertState
    {
        public void Alert(AlertStateContext ctx)
        {
            Console.WriteLine("Vibrating...");
        }
    }
}
