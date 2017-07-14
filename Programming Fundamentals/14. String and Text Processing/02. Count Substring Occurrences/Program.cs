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

        string input = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int counter = 0;
        int index = input.IndexOf(pattern);
        while (index != -1)
        {
            counter++;
            index = input.IndexOf(pattern, index + 1);
        }
        Console.WriteLine(counter);


    }
}

