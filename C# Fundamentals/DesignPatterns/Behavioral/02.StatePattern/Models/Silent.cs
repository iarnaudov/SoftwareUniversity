using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Silent : IMobileAlertState
    {
        public void Alert(AlertStateContext ctx)
        {
            Console.WriteLine("Silent...");
        }
    }
}
