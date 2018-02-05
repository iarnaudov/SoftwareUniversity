using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = input[0];
            var end = input[1];

            var command = Console.ReadLine();

            Predicate<int> filter;

            switch (command)
            {
                case "even": filter = n => n % 2 == 0; break;
                case "odd": filter = n => n % 2 != 0; break;
                default: filter = null; break;
            }

            var result = filterNums(start, end, filter);
            Console.WriteLine(string.Join(" ", result));
        }

        private static Queue<int> filterNums(int start, int end, Predicate<int> filter)
        {
            var numbers = new Queue<int>();

            for (int i = start; i <= end; i++)
            {
                if (filter(i))
                {
                    numbers.Enqueue(i);
                }
            }
            return numbers;
        }
    }
}
