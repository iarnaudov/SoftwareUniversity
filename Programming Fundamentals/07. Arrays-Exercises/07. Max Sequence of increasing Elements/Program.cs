using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw
{

    class Program
    {

        static void Main(string[] args)
        {
            //var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine().Split(' ');
            var sequence = new int[input.Length];


            for (int index = 0; index < sequence.Length; index++)
            {
                sequence[index] = int.Parse(input[index]);
            }

            int count = 1;
            int maxCount = 0;
            int maxIndexOfPos = int.MinValue;

            for (int index = 1; index < sequence.Length; index++)
            {
                int currentNumber = sequence[index];
                int prevNumber = sequence[index - 1];
                if (currentNumber > prevNumber)
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxIndexOfPos = index;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            int initialIndex = maxIndexOfPos - maxCount + 1;
            for (int index = initialIndex; index <= maxIndexOfPos; index++)
            {
                Console.Write($"{sequence[index]} ");
            }

        }
    }
}