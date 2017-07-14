using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split().ToArray();
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        string[] ingredients = new string[arr.Length];


        for (int i = 0; i < arr.Length; i++)
        {
            if (i==10)
            { 
                break;
            }
            if (arr[i].Length==n)
            {
                Console.WriteLine($"Adding {arr[i]}.");
                counter++;
                ingredients[i] += arr[i];
            }
        }
        ingredients = ingredients.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        Console.WriteLine($"Made pizza with total of {counter} ingredients.");
        Console.WriteLine("The ingredients are: {0}.",string.Join(", ", ingredients));




    }
}

