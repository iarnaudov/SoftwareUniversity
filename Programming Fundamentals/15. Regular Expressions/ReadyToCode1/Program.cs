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

        string text = "1-,$2,3-4%$,4,4-55=!$%5,    22";
        string pattern = @"[,-/=/!/$/%/ ]+";
        string[] results = Regex.Split(text, pattern);
        Console.WriteLine(string.Join(", ", results)); 
        // 1, 2, 3, 4




    }
}

