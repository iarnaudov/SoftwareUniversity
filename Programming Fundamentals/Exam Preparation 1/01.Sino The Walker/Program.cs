using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var inputTime = TimeSpan.Parse(Console.ReadLine()).TotalSeconds;
        long steps = int.Parse(Console.ReadLine());
        long timeStep = int.Parse(Console.ReadLine());
        long walkTimeInSeconds = steps * timeStep;

        //var secs = seconds % 60;
        //var mins = (seconds / 60) % 60;
        //var hours = (seconds / 60 / 60) % 24;

        var result = TimeSpan.FromSeconds((inputTime + walkTimeInSeconds));
        Console.WriteLine($"Time Arrival: {result.ToString(@"hh\:mm\:ss")}");
    }
}

