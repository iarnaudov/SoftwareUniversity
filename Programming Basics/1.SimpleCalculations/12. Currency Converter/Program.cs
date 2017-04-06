using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToUpper();
        string output = Console.ReadLine().ToUpper();
        double BGN = 1;
        double USD = 1.79549;
        double EUR = 1.95583;
        double GBP = 2.53405;

        if (input == "BGN") { a = a * BGN; }
        else if (input == "USD") { a = a * USD; }
        else if (input == "EUR") { a = a * EUR; }
        else if (input == "GBP") { a = a * GBP; }

        if (output == "BGN") { a = a / BGN; }
        else if (output == "USD") { a = a / USD; }
        else if (output == "EUR") { a = a / EUR; }
        else if (output == "GBP") { a = a / GBP; }

        Console.WriteLine("{0:f2} {1}", a, output);
    }
}
