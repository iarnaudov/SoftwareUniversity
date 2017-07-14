using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<decimal> items = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

  

            for (int i = 0; i < items.Count - 1;)
            {
                if (items[i] == items[i + 1])
                {
                    items.Insert(i, items[i] * 2);
                    items.RemoveAt(i + 1);
                    items.RemoveAt(i + 1);
                i = 0;
                }
                else
                {
                    i++;
                }
            
            }
        
        Console.WriteLine(string.Join(" ", items));



    }
}

