using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var players = Regex.Split(Console.ReadLine(), @"\s+").Where(t => t.Length>0).ToArray();
        var route = Regex.Split(Console.ReadLine(), @"\s+").Where(t => t.Length > 0).Select(p => double.Parse(p)*-1).ToArray();
        var checkpointIndexes = Regex.Split(Console.ReadLine(), @"\s+").Where( t=> t.Length>0).Select(long.Parse).Distinct().ToArray();

        foreach (var i in checkpointIndexes)
        {
            if (i>=0 && i<=route.Length)
            route[i] *= -1;
        }
        foreach (var p in players)
        {
            var fuel = (double)p[0];
            long index = 0;
            foreach (var r in route)
            {
                fuel += r;
                if (fuel <= 0)
                {
                    Console.WriteLine("{0} - reached {1}", p, index);
                    break;
                }
                index++;
            }
            if (fuel>0)
            {
                Console.WriteLine("{0} - fuel left {1:f2}", p, fuel);
            }
        }

    }
}

