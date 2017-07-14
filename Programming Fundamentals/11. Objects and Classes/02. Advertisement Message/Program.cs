using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var phrases = new List<string>()
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        var events = new List<string>()
       {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        var authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        var cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        Random rnd = new Random();
        int phraseIndex = rnd.Next(0, phrases.Count);
        int eventIndex = rnd.Next(0, events.Count);
        int authorIndex = rnd.Next(0, authors.Count);
        int townIndex = rnd.Next(0, cities.Count);



        Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[townIndex]}.");

    }
}

