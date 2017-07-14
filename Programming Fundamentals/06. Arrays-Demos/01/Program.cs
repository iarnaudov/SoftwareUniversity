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
        int[] newArray = new int[20];

        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i * 5;
        }
        Console.WriteLine(string.Join(" ",newArray));




    }
}

