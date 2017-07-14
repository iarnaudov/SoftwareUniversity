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
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var regex = new Regex($@"\|<");
        var text = Console.ReadLine();
        var splited = regex.Split(text);
        List<string> result = new List<string>();
        for (int i = 1; i < splited.Length; i++)
        {
           var word = splited[i].Skip(nums[0]).Take(nums[1]);
            result.Add(string.Join("",word));

        }
        Console.WriteLine(string.Join(", ", result));
    }
}

