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
        var regex = @"\b(?:0x)?[0-9A-F]+\b";
        var hexString = Console.ReadLine();
        var numbers = Regex.Matches(hexString, regex)
            .Cast<Match>()
            .Select(a => a.Value)
            .ToArray();
        Console.WriteLine(string.Join(" ", numbers));
            





    }
}

