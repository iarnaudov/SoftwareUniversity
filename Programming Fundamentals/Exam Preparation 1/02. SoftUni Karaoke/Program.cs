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
#region 1
        var allPlayers = Regex.Split(Console.ReadLine(), @"\s*,\s*");
        var allSongs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

        var awardsByPlayer = new Dictionary<string, List<string>>();
        foreach (var p in allPlayers)
        {
            awardsByPlayer[p] = new List<string>();
        }
#endregion
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "dawn") break;
            var tokens = Regex.Split(command, @"\s*,\s*");
            var player = tokens[0];
            var song = tokens[1];
            var award = tokens[2];
            if (allPlayers.Contains(player) && allSongs.Contains(song))
            {
                awardsByPlayer[player].Add(award);
            }
        }
        var result = awardsByPlayer
            .Select(item => new
            {
                player = item.Key,
                awards = item.Value.Distinct().OrderBy(a => a),
                awardsCount = item.Value.Distinct().Count()
            })
            .OrderByDescending(item => item.awardsCount)
            .ThenBy(item => item.player)
            .Where(item => item.awardsCount>0) 
            .ToArray();

        foreach (var p in result)
        {
            Console.WriteLine($"{p.player}: {p.awardsCount} awards");
            foreach (var aw in p.awards)
            {
                Console.WriteLine($"--{aw}");
            }
        }
        if (result.Length==0)
        {
            Console.WriteLine("No awards");
        }
    }
}

