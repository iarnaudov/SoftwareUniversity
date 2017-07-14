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
        var input = Console.ReadLine().ToUpper();
        var matches = Regex.Matches(input, @"(\D+)(\d+)");
        StringBuilder result = new StringBuilder();
        foreach (Match match in matches)
        {
            var text = match.Groups[1].Value;
            var count = int.Parse(match.Groups[2].Value);
            for (int i = 0; i < count; i++)
            {
                result.Append(text);
            }
        }
        Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
        Console.WriteLine(result);


    }
}

