using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();

            while (true)
            {
                var arr = Console.ReadLine().Split().ToArray();

                var charTosearch = arr[0];
                var minimumcount = int.Parse(arr[1]);

                var indexOfTheFirstChar = Regex.Match(map, @"(?=.?[" + charTosearch + "]{" + minimumcount + "})([" + charTosearch + "]+)").Index;
                var lengthOfTheFoundString = Regex.Match(map, @"(?=.?[" + charTosearch + "]{" + minimumcount + "})([" + charTosearch + "]+)").Length;

                if (indexOfTheFirstChar > 0)
                {
                    Console.WriteLine($"Hideout found at index {indexOfTheFirstChar} and it is with size {lengthOfTheFoundString}!");

                    break;
                }
            }
        }
    }
}