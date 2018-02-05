using System;
using System.Linq;

namespace _01._ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            Action<string[]> Print = s => 
            {
                foreach (var item in s)
                {
                    Console.WriteLine(item);
                }
            };
            Print(input);
        }
    }
}
