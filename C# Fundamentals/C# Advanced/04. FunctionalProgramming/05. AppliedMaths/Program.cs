using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AppliedMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;

            while ((command = Console.ReadLine().ToLower().Trim()) != "end")
            {
                switch (command)
                {
                    case "add": numbers = ApplyOperation(numbers, n => n + 1); break;
                    case "multiply": numbers = ApplyOperation(numbers, n => n * 2); break;
                    case "subtract": numbers = ApplyOperation(numbers, n => n - 1); break;
                    case "print": Console.WriteLine(string.Join(" ", numbers)); break;
                    default:
                        break;
                }

            }
           
        }

        private static int[] ApplyOperation(int[] numbers, Func<int, int> func)
        {
            return numbers.Select(func).ToArray();
        }
    }
}
