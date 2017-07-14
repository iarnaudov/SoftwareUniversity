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
        string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
        string input = Console.ReadLine();
        MatchCollection matchedNames = Regex.Matches(input, regex);

        foreach (var item in matchedNames)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();

    }
}

