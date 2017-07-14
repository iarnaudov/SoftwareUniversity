using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var bestIndex = 0;
        var bestLenght = 1;
        var currentStartIndex = 0;
        var currentLenght = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            
            if (arr[i]==arr[i-1])
            {
                currentLenght++;
                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    bestIndex = currentStartIndex;
                }
            }
            else
             {
                    currentStartIndex = i;
                    currentLenght = 1;
                    
             }

        }
        for (int i = bestIndex; i <  bestIndex + bestLenght; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();


    }
}

