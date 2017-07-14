using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Demons
{
    public string Name { get; set; }
    public double Damage { get; set; }
    public int Health { get; set; }
}
class Program
{
    static void Main()
    {
        var collection = Regex.Split(Console.ReadLine(), @",\s+");
        var demonsList = new List<Demons>();
        var healthPattern = @"[^\d+\+\-\*\/\.]";
        foreach (var input in collection)
        {
            var healthMatch = Regex.Matches(input, healthPattern);
            var healthSum = 0;
            var healthArray = healthMatch
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            foreach (var letter in healthArray)
            {
                healthSum += char.Parse(letter); // TotalHealth
            }

            var damagePattern = @"-?\d+(.\d+)?";
            var damageMatch = Regex.Matches(input, damagePattern);
            double damageSum = 0;
            var damageArray = damageMatch
                  .Cast<Match>()
                  .Select(m => m.Value)
                  .ToArray();
            foreach (var num in damageArray)
            {
                damageSum += double.Parse(num); // TotalDamage from digits
            }

            var multiply = @"[\*|\/]";
            var multiplyMatch = Regex.Matches(input, multiply);
            var multiplyArray = multiplyMatch
                  .Cast<Match>()
                  .Select(m => m.Value)
                  .ToList();
            for (int i = 0; i < multiplyArray.Count; i++)
            {
                if (char.Parse(multiplyArray[i]) == '*')
                {
                    damageSum *= 2;
                }
                else
                {
                    damageSum /= 2;
                }
            }
            var demons = new Demons()
            {
                Name = input,
                Health = healthSum,
                Damage = damageSum
            };
            demonsList.Add(demons);
      }
        var ordered = demonsList.OrderBy(a => a.Name).ToArray();
        foreach (var demon in ordered)
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }
        

    }
}

