using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class AlertStateContext
    {
        private IMobileAlertState currentState;

        public AlertStateContext()
        {
            currentState = new Ringing();
        }

        public void setState(IMobileAlertState state)
        {
            currentState = state;
        }

        public void Alert()
        {
            currentState.Alert(this);
        }
    }
}
