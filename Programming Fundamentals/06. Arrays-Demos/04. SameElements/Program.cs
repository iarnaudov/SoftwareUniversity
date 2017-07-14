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
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int newcounter = 0;
        int result = 0;

        for (int i = 1; i <= arr1.Length; i++)
        {
            if (arr1[i] == arr1[i-1])
            {
                newcounter++;
                result = arr1[i];
            }
            else if (arr1[i] != arr1[i - 1])
            {
                newcounter = 1;
            }
        }




    }
}

