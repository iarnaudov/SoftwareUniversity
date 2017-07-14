using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int currentNum = 0;
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentNum = numbers[i];
            for (int j = i; j < numbers.Length; j++)
            {
                if (Math.Abs(currentNum - numbers[j]) == difference)
                {
                    counter++;
                }


            }
        }
        Console.WriteLine(counter);



    }
}

