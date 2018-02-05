using System;
using System.Linq;

namespace _03._MinFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> SmallestNum = n => n.Min();

            Console.WriteLine(SmallestNum(input)); 
        }
    }
}
