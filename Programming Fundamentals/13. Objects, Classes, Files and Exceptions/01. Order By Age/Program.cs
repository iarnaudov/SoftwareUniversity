using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

class People
{
    public string Name { get; set; }

    public string ID { get; set; }

    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var command = Console.ReadLine().Split().ToArray();
        var people = new List<People>() {
           
        };

        while (command[0] != "End")
        {
            string name = command[0];
            string id = command[1];
            int age = int.Parse(command[2]);

            var person = new People()
            {
                Name = name,
                ID = id,
                Age = age
            };
            people.Add(person);     
            
            command = Console.ReadLine().Split().ToArray();
        }

        var sortedPeople = people.OrderBy(a => a.Age);

        foreach (var item in sortedPeople)
        {
            Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
        }



    }
}

