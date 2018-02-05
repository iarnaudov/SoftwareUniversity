using System;
using System.Linq;

namespace _02._KnightsOfHonor
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
                    Console.WriteLine("Sir " + item);
                }
            };
            Print(input);
        }
    }
}
