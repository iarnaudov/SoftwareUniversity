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
        string input = Console.ReadLine();
        foreach (char c in input)
        {
            Console.Write("\\u" + ((int)c).ToString("x4"));
        }
        Console.WriteLine();




    }
}

