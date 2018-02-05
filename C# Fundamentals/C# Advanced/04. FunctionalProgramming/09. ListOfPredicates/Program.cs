using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();

            var predicates = dividers
              .Select(div => (Func<int, bool>)(n => n % div == 0))
              .ToArray();

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsValid(predicates, i))
                {
                    list.Add(i);
                }
             
            }
            Console.WriteLine(string.Join(" ", list)); 
        }

        private static bool IsValid(Func<int, bool>[] predicates, int num)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(num))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
