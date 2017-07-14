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
        var regex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";
        var text = Console.ReadLine();
        var matches = Regex.Matches(text, regex);

        foreach (var email in matches)
        {
            Console.WriteLine(email);
        }




    }
}

