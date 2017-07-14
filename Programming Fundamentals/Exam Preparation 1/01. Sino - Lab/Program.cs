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
        var nums = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
        long seconds = nums[2] + 60 * nums[1] + 60 * 60 * nums[0];
        var secondstoAdd =
            long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine());
        seconds = seconds + secondstoAdd;

        var secs = seconds % 60;
        var mins = (seconds / 60) % 60;
        var hours = (seconds / 60 / 60) % 24;

        Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", hours,mins,secs);




    }
}

