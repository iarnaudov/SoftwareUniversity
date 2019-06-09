using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Ringing : IMobileAlertState
    {
        public void Alert(AlertStateContext ctx)
        {
            Console.WriteLine("Ringing...");
        }
    }
}
