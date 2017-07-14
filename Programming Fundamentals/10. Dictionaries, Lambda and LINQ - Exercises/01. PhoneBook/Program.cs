using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        string[] command = new string[3];
        

        while (true)
        {
            command = Console.ReadLine().Split().ToArray();
            
            if (command[0] == "END") { break; }
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
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }

        }
    }
}

