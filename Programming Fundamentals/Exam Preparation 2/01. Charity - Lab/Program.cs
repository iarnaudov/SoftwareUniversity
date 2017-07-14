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
        var marathonDays = decimal.Parse(Console.ReadLine());
        var runnersCount = decimal.Parse(Console.ReadLine());
        var lapsCount = decimal.Parse(Console.ReadLine());
        var trackLenght = decimal.Parse(Console.ReadLine());
        var trackCapacity = decimal.Parse(Console.ReadLine());
        var moneyPerKm = decimal.Parse(Console.ReadLine());

        var totalDistance = Math.Min(runnersCount,trackCapacity * marathonDays) * lapsCount * trackLenght;

        var moneyRaised = (totalDistance / 1000) * moneyPerKm;
        Console.WriteLine($"Money raised: {moneyRaised:f2}");

    }
}

