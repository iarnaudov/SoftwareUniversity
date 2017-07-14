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
        string[] arr1 = Console.ReadLine().Split(' ').ToArray();
        string[] arr2 = Console.ReadLine().Split(' ').ToArray();
       
        if (arr1.Length == arr2.Length)
        {
            bool[] result = new bool[arr1.Length];
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    result[i] = true;
                    counter++;
                }
                else
                {
                    result[i] = false;
                }   
            }
            if (counter==arr1.Length)
            {
                Console.WriteLine("the same");
            }
            else
            {
                Console.WriteLine("not the same");
            }
        }
        else
        {
            Console.WriteLine("not the same");
        }
    }
}

