using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PartyReservationFilter
{
    class Program
    {
        public static List<string> copiedPeople = new List<string>();

        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(new char[] { ' ', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            copiedPeople = new List<string>(people);

            string[] command = Console.ReadLine().Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (true)
            {
                if (command[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ", people));
                    return;
                }
                switch (command[1].ToLower())
                {
                    case "starts with": people = ApplyFilter(command[0], people, n => n.StartsWith(command[2])); break;
                    case "ends with": people = ApplyFilter(command[0], people, n => n.EndsWith(command[2])); break;
                    case "length": people = ApplyFilter(command[0], people, n => n.Length == int.Parse(command[2])); break;
                    case "contains": people = ApplyFilter(command[0], people, n => n.Contains(command[2])); break;
                    default:
                        break;
                }

              command = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            
        }

        private static List<string> ApplyFilter(string command, List<string> people, Func<string, bool> filter)
        {
                switch (command.ToLower())
                {
                    case "add filter": people = people.Except(people.Where(p => filter(p))).ToList(); break;
                    case "remove filter":  people.AddRange(copiedPeople.Where(p => filter(p))); break;
                    default:
                        break;
                }
            return people;
        }
    }
}
