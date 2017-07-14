using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> array = Console.ReadLine().ToLower().Split().ToList();
        var dict = new SortedDictionary<string, int>();
        List<string> result = new List<string>();
        foreach (var item in array)
        {
            dict[item]=0;
        }
        foreach (var item in array)
        {
            dict[item]++;
        }
        foreach (var p in dict)
        {
            if (p.Value%2==1)
            {
                result.Add(p.Key);
            }
            
        }
        Console.WriteLine(string.Join(", ", result));


    }
}

