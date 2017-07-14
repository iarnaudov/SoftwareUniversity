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
        var separator = Console.ReadLine();
        var sentences = Regex.Split(Console.ReadLine(), @"[!\.?] ");
        foreach (var item in sentences)
        {

            if (item.Contains(" "+separator+" "))
            {
                Console.WriteLine(item);
            }

        }
    }
}

