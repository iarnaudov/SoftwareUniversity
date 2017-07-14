using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] times = Console.ReadLine().Split(' ');

        var orderedTimes = times.OrderBy(x => x);

        Console.WriteLine(string.Join(", ", orderedTimes));
    }


    
}

