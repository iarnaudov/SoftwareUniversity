using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Library
{
    public string Name { get; set; }

    public List<Book> Books { get; set; }

}

class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public string Publisher { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string Isbn { get; set; }

    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var library = new Library()
        {
            Name = "Prosveta",
            Books = new List<Book>()
        };


        var booksCount = int.Parse(Console.ReadLine());
        var format = "dd.MM.yyyy";

        for (int i = 0; i < booksCount; i++)
        {
            var tokens = Console.ReadLine().Split();

            var title = tokens[0];
            var author = tokens[1];
            var publisher = tokens[2];
            var releaseDate = DateTime.ParseExact(tokens[3], format, CultureInfo.InvariantCulture);
            var isbn = tokens[4];
            var price = decimal.Parse(tokens[5]);

            var book = new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                Isbn = isbn,
                Price = price
            };
            library.Books.Add(book);
        }
        DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        var outputbooks = library.Books
            .OrderBy(a => a.ReleaseDate)
            .ThenBy(a => a.Title)
            .Where(a => a.ReleaseDate > givenDate)
            .ToArray();
        foreach (var item in outputbooks)
        {
            Console.WriteLine(string.Join(" -> ", item.Title, item.ReleaseDate.ToString(format)));
        }

        Console.WriteLine();

        
    }
}

