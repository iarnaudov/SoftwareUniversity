using System;

namespace _03.CommandPattern
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            // Create receiver, command, and invoker
            Light light = new Light();
            LightOnCommand command = new LightOnCommand(light);
            CommandInvoker invoker = new CommandInvoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user
            Console.ReadKey();
        }
    }
}
