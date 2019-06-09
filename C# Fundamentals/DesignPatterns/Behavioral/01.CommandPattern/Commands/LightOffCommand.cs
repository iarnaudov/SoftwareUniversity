using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    public class LightOffCommand : ICommand
    {
        private Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    } 
}
