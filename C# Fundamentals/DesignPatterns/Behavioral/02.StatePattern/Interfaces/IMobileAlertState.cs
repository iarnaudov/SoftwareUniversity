using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IMobileAlertState
    {
        void Alert(AlertStateContext ctx);
    }
}
