using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToArray();
            Predicate<string> filter = n => n.Count() <= m ? true : false;

            var filteredNames = names.Where(n => filter(n));
            Console.WriteLine(string.Join(Environment.NewLine, filteredNames));

        }
    }
}
