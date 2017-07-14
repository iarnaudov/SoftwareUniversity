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
        string key = Regex.Escape(Console.ReadLine());
        var pattern = string.Format
            (@"^.*(?:{0})(?<team1>[a-zA-Z]*)(?:{0}).* .*(?:{0})(?<team2>[a-zA-Z]*)(?:{0}).* (?<team1Score>\d+):(?<team2Score>\d+).*$", key);

        var matchRegex = new Regex(pattern);
        var matches = new Dictionary<string, Score>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line == "final"){ break; }
            var match = matchRegex.Match(line);
            var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
            var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());

            var team1Goals = int.Parse(match.Groups["team1Score"].Value);
            var team2Goals = int.Parse(match.Groups["team2Score"].Value);

            ///////////////////////////////////////////////////////////////

            if (!matches.ContainsKey(team1Name))
            {
                matches[team1Name] = new Score();
            }
            if (!matches.ContainsKey(team2Name))
            {
                matches[team2Name] = new Score();
            }
            matches[team1Name].Goals += team1Goals;
            matches[team2Name].Goals += team2Goals;

            if (team1Goals>team2Goals) //team1 wins, team 2 lose
            {
                matches[team1Name].Points += 3;
            }
            else if (team1Goals < team2Goals)//team 2 wins, team 1 lose
            {
                matches[team2Name].Points += 3;
            }
            else 
            {
                matches[team1Name].Points += 1;
                matches[team2Name].Points += 1;
            }
        }
        ////////////// SORTING ///////////////////

        var leagueStandings = matches
            .OrderByDescending(a => a.Value.Points)
            .ThenBy(a => a.Key).ToArray();

        Console.WriteLine("League standings:");
        for (int i = 0; i < leagueStandings.Length; i++)
        {
            var currentStanding = leagueStandings[i];
            var place = i + 1;
            var country = currentStanding.Key;
            var points = currentStanding.Value.Points;
            Console.WriteLine($"{place}. {country} {points}");
        }

        var top3Goals = matches
           .OrderByDescending(a => a.Value.Goals)
           .ThenBy(a => a.Key).Take(3).ToArray();

        Console.WriteLine("Top 3 scored goals:");
        foreach (var pair in top3Goals)
        {
            var country = pair.Key;
            var goals = pair.Value.Goals;
            Console.WriteLine($"- {country} -> {goals}");
        }
    }
}

 class Score
{
    public decimal Points { get; set; }
    public decimal Goals { get; set; }
}