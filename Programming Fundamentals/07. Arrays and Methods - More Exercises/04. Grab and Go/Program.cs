using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        int position = -1;
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==n)
            {
                position = i;
            }
        }
        for (int i = 0; i < position; i++)
        {
            sum += arr[i];
        }

        if (position==-1)
        {
            Console.WriteLine("No occurrences were found!");
        }
        else
        {
            Console.WriteLine(sum);
        }




    }
}

