using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            var a = int.Parse(Console.ReadLine());

            Predicate<int> print = n => n % a != 0;

            var numbers = input.Where(n => print(n));
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
