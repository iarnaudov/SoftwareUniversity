using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var namesIPsDurations = new SortedDictionary<string, SortedDictionary<string, int>>();
        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var line = Console.ReadLine();
            var tokens = line.Split();
            var name = tokens[1];
            var ip = tokens[0];
            var duration = int.Parse(tokens[2]);

            if (!namesIPsDurations.ContainsKey(name))
            {
                namesIPsDurations[name] = new SortedDictionary<string, int>();
            }

            if (!namesIPsDurations[name].ContainsKey(ip))
            {
                namesIPsDurations[name][ip] = 0;

            }
            namesIPsDurations[name][ip] += duration;
        }
        foreach (var nameIpsDurations in namesIPsDurations)
        {
            var name = nameIpsDurations.Key;
            var ipsDurations = nameIpsDurations.Value;
            var totalDurations = ipsDurations.Sum(a => a.Value);
            var ips = ipsDurations.Select(a => a.Key).ToArray();
            Console.WriteLine($"{name}: {totalDurations} [{string.Join(", ", ips)}]");
        }



    }
}

