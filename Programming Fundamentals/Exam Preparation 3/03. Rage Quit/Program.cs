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
        var command = Console.ReadLine().ToUpper();
        var input = command.ToLower().Where(c => !Char.IsDigit(c)).Distinct().ToArray();
        int n = input.Length;
        var matches = Regex.Matches(command, @"(\D+)(\d+)");
        var result = new StringBuilder();
        foreach (Match match in matches)
        {
            var list = String.Concat(Enumerable.Repeat(match.Groups[1], int.Parse(match.Groups[2].Value)));
            result.Append(list);
        }
        Console.WriteLine($"Unique symbols used: {n}");
        Console.WriteLine(result);
    }
}
