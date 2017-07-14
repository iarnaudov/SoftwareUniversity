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
        var strings = Console.ReadLine()
            .Split()
            .Select(a => a.ToCharArray()
            .Distinct().ToArray()).ToArray();


        var firstLenght = strings.First().Length;
        Console.WriteLine(strings.All(a=>a.Length==firstLenght).ToString().ToLower());


    }
} 

