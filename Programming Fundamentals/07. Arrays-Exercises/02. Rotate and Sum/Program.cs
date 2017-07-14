using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();             
        int k = int.Parse(Console.ReadLine());

        int[] result = new int[array.Length];
        int[] numbers = new int[array.Length];
        for (int i = 0; i < k; i++)
        {
            int temp = array[array.Length - 1];
            for (int j = array.Length-1; j >= 1; j--)
            {
                result[j] += array[j - 1];
                numbers[j] = array[j - 1];
            }
            numbers[0] = temp;
            result[0] += temp;
            
        }
        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine(string.Join(" ", result));
        
    }
}

