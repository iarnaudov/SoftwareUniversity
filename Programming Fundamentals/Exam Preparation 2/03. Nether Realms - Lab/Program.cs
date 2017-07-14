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
        var demons = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(Demon.Parse)
            .OrderBy(a => a.Name)
            .ToArray();

        foreach (var demon in demons)
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }


    }
}
class Demon
{
    public string Name { get; set; }
    public decimal Health { get; set; }
    public decimal Damage { get; set; }

    public static Demon Parse(string demonStr)
    {
        var name = demonStr;
        var healthRegex = new Regex(@"[^\d+\+\-\*\/\.]");
        var damageRegex = new Regex(@"-?\d+(?:\.\d+)?");

        var health = healthRegex.Matches(demonStr)
            .Cast<Match>()
            .Select(a => (int)char.Parse(a.Value))
            .Sum();

        var damage = damageRegex.Matches(demonStr)
            .Cast<Match>()
            .Select(a => decimal.Parse(a.Value))
            .Sum();

        var multiplyCount = demonStr.Count(a => a == '*');
        var divideCount = demonStr.Count(a => a=='/');
        damage *= (decimal)Math.Pow(2, multiplyCount);
        damage /= (decimal)Math.Pow(2, divideCount);
        var demon = new Demon()
        {
            Name = name,
            Damage = damage,
            Health = health
        };
        return demon;
    }
}

