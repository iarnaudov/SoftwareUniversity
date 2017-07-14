using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var phonebook = new SortedDictionary<string, string>();
        string[] command = Console.ReadLine().Split().ToArray();


        while (true)
        {
           

            if (command[0] == "END") { break; }
            if (command[0] == "ListAll")
            {
                //foreach (var item in phonebook)
                //{
                //    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                //}


                phonebook.ToList().ForEach(x => Console.WriteLine("{0} -> {1}", x.Key, x.Value));
                break;

            }
            if (command[0] == "A")
            {
                var name = command[1];
                var number = command[2];
                phonebook[name] = number;
            }
            else if (command[0] == "S")
            {
                var name = command[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    phonebook.Remove(name);
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exists.");
                   
                }
            }
            command = Console.ReadLine().Split().ToArray();

        }
    }
}

