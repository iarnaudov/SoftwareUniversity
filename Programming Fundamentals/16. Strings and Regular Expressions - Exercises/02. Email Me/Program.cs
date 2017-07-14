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
        string[] input = Console.ReadLine().Split('@').ToArray();
        var rightSum = input[1].ToCharArray().Sum(a => a);
        var leftSum = input[0].ToCharArray().Sum(a => a);
        if (rightSum - leftSum > 0)
        {
            Console.WriteLine("She is not the one.");
        }
        else
        {
            Console.WriteLine("Call her!");
        }
    }
}

