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
        var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
        var numberStrings = Console.ReadLine();
        var numbers = Regex.Matches(numberStrings, regex);

        foreach (Match number in numbers)
        {
            Console.Write(number.Value + " ");
        }

        Console.WriteLine();


    }
}

