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

        var regex = @"(\+\d{3}\d{1}-\d{3}-\d{4})|(\+\d{3} \d{1} \d{3} \d{4})";
        var input = Console.ReadLine();
        var matches = Regex.Matches(input, regex);

        var matchedPhones = matches.Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();
        Console.WriteLine(string.Join(", ",matchedPhones));




    }
}

