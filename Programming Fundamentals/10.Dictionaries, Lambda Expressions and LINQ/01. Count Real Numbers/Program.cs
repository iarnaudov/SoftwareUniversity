using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[] counts = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var dict = new SortedDictionary<double, int>();

        foreach (var num in counts)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
            
        }
        foreach (var p in dict)
        {
            Console.WriteLine(p.Key + " -> " + p.Value);
        }


    }
}

