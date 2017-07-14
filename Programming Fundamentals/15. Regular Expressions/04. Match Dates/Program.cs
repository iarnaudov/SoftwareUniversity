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
        string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        var dateStrings = Console.ReadLine();
        var dates = Regex.Matches(dateStrings, regex);

        foreach (Match date in dates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            
        }



    }
}

