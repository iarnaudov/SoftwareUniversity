using System;

namespace StatePattern
{
    /// <summary>
    /// State design pattern is used when an Object changes its behavior based on its internal state.
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            AlertStateContext stateContext = new AlertStateContext();
            stateContext.Alert();
            stateContext.setState(new Vibration());
            stateContext.Alert();
            stateContext.Alert();
            stateContext.setState(new Silent());
            stateContext.Alert();
            stateContext.Alert();
        }
    }
}