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
        char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
       
        if (arr1.Length<arr2.Length)
        {
            Console.WriteLine(arr1);
            Console.WriteLine(arr2);
        }
        else if (arr1.Length > arr2.Length)
        {
            Console.WriteLine(arr2);
            Console.WriteLine(arr1);
        }
        else if (arr1.Length == arr2.Length)
        {
            bool[] result = new bool[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
             result[i] = arr1[i] == arr2[i] ? true : false;
                if (result[i] == false)
                {
                    if (arr1[i]<arr2[i])
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                        break;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                        break;
                    }
                  
                }
            }


        }



    }
}

