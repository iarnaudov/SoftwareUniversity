using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var strings = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        foreach (var str in strings)
        {
            var firstLetter = str.First();
            var lastLetter = str.Last();
            var number = double.Parse(str.Substring(1, str.Length - 2));

            if (char.IsUpper(firstLetter))
            {
                var charPosition = firstLetter - ('A' - 1);
                number /= charPosition;
            }
            else
            {
                number *= firstLetter - ('a' - 1);
            }
            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - ('A' - 1);
            }
            else
            {
                number += lastLetter - ('a' - 1);   
            }
            sum += number;
        }
        Console.WriteLine($"{sum:f2}");



    }
}

