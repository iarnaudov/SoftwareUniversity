using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] product = Console.ReadLine().Split().ToArray();
        long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
        decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

        string command = Console.ReadLine();

        while (command != "done")
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i] == command)
                {
                    Console.WriteLine("{0} costs: {1}; Available quantity: {2}", product[i], prices[i], quantity[i]);
                } 
            }
            command = Console.ReadLine();
        }




    }
}

