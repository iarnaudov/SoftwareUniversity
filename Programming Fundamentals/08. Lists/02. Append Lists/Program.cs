using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split('|').ToArray();
        List<string> result = new List<string>();

        for (int i = inputArray.Length-1; i >= 0; i--)
        {
          List <string> newarr = inputArray[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //result.Add(string.Join(" ", newarr));
            result.AddRange(newarr);
        }

        Console.WriteLine(string.Join(" ", result));


    }
}

