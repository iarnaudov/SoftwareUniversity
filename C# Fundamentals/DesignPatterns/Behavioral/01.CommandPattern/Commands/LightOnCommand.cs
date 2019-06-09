using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    class LightOnCommand : ICommand
    {
        private Light light;

        // The constructor is passed the light it is going to control. 
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
