using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int currentNum = 0;
        int leftSide = 0;
        int rightSide = 0;
        if (arr.Length == 1)
        {
            Console.WriteLine("0");
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            currentNum = arr[i];
            if (arr[i] == arr[0])
            {
                leftSide = 0;
                rightSide = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSide += arr[j];
                }
                if (leftSide == rightSide)
                {
                    Console.WriteLine(arr[0]);
                    break;
                }

            }
            if (true)
            {
                leftSide = 0;
                rightSide = 0;
                for (int j = 0; j < i; j++)
                {

                    leftSide += arr[j];
                }
                for (int j = arr.Length - 1; j > i; j--)
                {

                    rightSide += arr[j];
                }
                if (leftSide == rightSide)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (arr[i] == arr.Length)
            {
                rightSide = 0;
                leftSide = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    leftSide += arr[j];
                }
                if (leftSide == rightSide)
                {
                    Console.WriteLine(i);
                    break;  
                }
                else
                {
                    Console.WriteLine("no");
                    break;
                }
            }
        }
           
        
    }
}

