namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using System.Linq;
    using System.Collections.Generic;
    using System;
    using BookShop.Models;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
     public static void Main()
        {
            using (var context = new BookShopContext())
            {
                // DbInitializer.ResetDatabase(context);

                //01. GetBooksByAgeRestriction

                //string ageRestriction = Console.ReadLine().ToLower();
                //string bookTitles = GetBooksByAgeRestriction(context, ageRestriction);
                //Console.WriteLine(bookTitles);

                //02. Golden Books
                //string goldenBooks = GetGoldenBooks(context);
                //Console.WriteLine(goldenBooks);


                //03. GetBooksByPrice
                //var books = GetBooksByPrice(context);
                //Console.WriteLine(books);

                //04. NotReleasedIn
                //int year = int.Parse(Console.ReadLine());
                //var books = GetBooksNotRealeasedIn(context, year);
                //Console.WriteLine(books);

                //05. BookTitlesByCategory
                //var input = Console.ReadLine().ToLower();
                //var books = GetBooksByCategory(context, input);
                //Console.WriteLine(books);

                //06. ReleasedBeforeDate
                //string releaseDate = Console.ReadLine();
                //var booksBefore = ReleasedBeforeDate(context, releaseDate);
                //Console.WriteLine(booksBefore);

                //07. GetAuthorNamesEndingIn
                //string firstnameEnding = Console.ReadLine();
                //var authors = GetAuthorNamesEndingIn(context, firstnameEnding);
                //Console.WriteLine(authors);

                //08. Book Search
                //string containingString = Console.ReadLine().ToLower();
                //var titles = GetBookTitlesContaining(context, containingString);
                //Console.WriteLine(titles);

                //09. GetBooksByAuthor
                //string containingString = Console.ReadLine().ToLower();
                //var titles = GetBooksByAuthor(context, containingString);
                //Console.WriteLine(titles);

                //10. CountBooks
                //int lenghtCheck = int.Parse(Console.ReadLine());
                //var numOfBooks = CountBooks(context, lenghtCheck);
                //Console.WriteLine(numOfBooks);

                //11. Total Book Copies
                //var totalCopiesByAuthor = CountCopiesByAuthor(context);
                //Console.WriteLine(totalCopiesByAuthor);

                //12. ProfitByCategory
                //Console.WriteLine(GetTotalProfitByCategory(context));

                //13. Most Recent Books
                // Console.WriteLine(GetMostRecentBooks(context)); 

                // 14. Increase prices
                //IncreasePrices(context);

                // 15. Remove Books
              //  int removedBooks = RemoveBooks(context);
              //  Console.WriteLine($"{removedBooks} books were deleted");
            }
        }


        public static string GetBooksByAgeRestriction(BookShopContext context, string ageRestriction)
        {
            int enumValue;

            switch (ageRestriction.ToLower())
            {
                case "minor":
                    enumValue = 0;
                    break;
                case "teen":
                    enumValue = 1;
                    break;
                case "adult":
                    enumValue = 2;
                    break;
                default:
                    enumValue = -1;
                    break;
            }
            var titles = context.Books.Where(b => b.AgeRestriction == (AgeRestriction)enumValue).Select(b => b.Title).OrderBy(b => b).ToList();
            return string.Join(Environment.NewLine, titles);




        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBooks = context.Books.Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000).OrderBy(b => b.BookId).Select(b => b.Title).ToArray();
            return string.Join(Environment.NewLine, goldenBooks);

        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books.Where(b => b.Price > 40).OrderByDescending(b => b.Price).Select(b => new { b.Price, b.Title }).ToArray();
            return string.Join(Environment.NewLine, books.Select(x => $"{x.Title} - ${x.Price:f2}"));

        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var books = context.Books.Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year != year).OrderBy(x => x.BookId).Select(x => x.Title).ToArray();
            return string.Join(Environment.NewLine, books);

        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split().ToArray();

            var titles = context.Books.Where(b => b.BookCategories.Select(c => c.Category.Name.ToLower()).Intersect(categories).Any()).Select(b => b.Title).OrderBy(b => b).ToList();
            return string.Join(Environment.NewLine, titles);
        }

        public static string ReleasedBeforeDate(BookShopContext context, string date)
        {
            DateTime newDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var books = context.Books.Where(b => b.ReleaseDate != null && b.ReleaseDate.Value < newDate).OrderByDescending(x => x.ReleaseDate.Value).Select(b => new
            {
                b.Title,
                b.Price,
                b.EditionType
            }).ToList();

            return string.Join(Environment.NewLine, books.Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}"));

        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors.Where(a => a.FirstName.EndsWith(input)).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(a => new { a.FirstName, a.LastName }).ToList();
            return string.Join(Environment.NewLine, authors.Select(a => $"{a.FirstName} {a.LastName}"));
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books.Where(b => b.Title.ToLower().Contains(input.ToLower())).OrderBy(x => x.Title).Select(b => b.Title).ToList();

            return string.Join(Environment.NewLine, titles);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var authors = context.Books.Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(x => x.BookId).Select(b => new
                {
                    b.Title,
                    FullName = $"{b.Author.FirstName} {b.Author.LastName}"
                }).ToList();

            return string.Join(Environment.NewLine, authors.Select(a => $"{a.Title} ({a.FullName})"));
        }

        public static int CountBooks(BookShopContext context, int lenghtCheck)
        {
            var books = context.Books.Where(b => b.Title.Length > lenghtCheck).ToList();
            return books.Count();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var books = context.Books
           .Select(b => new
           {
               AuthorName = b.Author.FirstName + " " + b.Author.LastName,
               b.Copies
           })
           .GroupBy(b => b.AuthorName)
           .OrderByDescending(x => x.Sum(y => y.Copies))
           .ToArray();

            return string.Join(Environment.NewLine, books.Select(x => x.Key + " - " + x.Sum(y => y.Copies)));
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Profit = c.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
                })
                .OrderBy(x => x.Name)
                .OrderByDescending(x => x.Profit)
                .ToArray();

            return string.Join(Environment.NewLine, categories.Select(x => x.Name + " $" + x.Profit));
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories.OrderBy(c => c.Name).Select(c => new
            {
                c.Name,
                Books = c.CategoryBooks.Select(cb => cb.Book)
                .OrderByDescending(b => b.ReleaseDate).Take(3)
            }).ToList();

            var builder = new StringBuilder();

            foreach (var c in categories)
            {
                builder.AppendLine($"--{c.Name}");
                foreach (var b in c.Books)
                {
                    string year = null;
                    if (b.ReleaseDate == null)
                    {
                        year = "N/A";
                    }
                    else
                    {
                        year = b.ReleaseDate.Value.Year.ToString();
                    }
                    builder.AppendLine($"{b.Title} ({year})");
                }
            }
            return builder.ToString();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(b => b.ReleaseDate.Value.Year < 2010).ToList();

            foreach (var b in books)
            {
                b.Price += 5m;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(b => b.Copies < 4200).ToList();
            int result = books.Count;
            context.Books.RemoveRange(books);
            context.SaveChanges();
            return result;
        }
    }
}
