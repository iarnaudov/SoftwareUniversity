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
        StringBuilder result = new StringBuilder();
        
        for (int i = input.Length-1; i >= 0; i--)
        {
           result.Append(input[i]);
        }

        Console.WriteLine(result);

    }
}

