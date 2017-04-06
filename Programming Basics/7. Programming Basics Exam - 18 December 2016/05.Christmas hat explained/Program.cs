using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int startEndDots = 2 * n - 1;
        //Първите 2 реда
        Console.Write(new string('.',startEndDots));
        Console.Write(@"/|\");
        Console.WriteLine(new string('.', startEndDots));
        Console.Write(new string('.', startEndDots));
        Console.Write(@"\|/");
        Console.WriteLine(new string('.', startEndDots));

        //средната част
        for (int row = 0; row < 2 * n; row++)
        {
            Console.WriteLine(
                new string('.', startEndDots - row) +
                "*" +
            new string('-', row) +
                 "*" +
            new string('-', row) +
            "*" +
        new string('.', startEndDots - row));
        }
        //последните 3 реда
        Console.WriteLine(new string ('*', 4 * n + 1));
        Console.Write("*");
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write(".*");
           
        }
        Console.WriteLine();
        Console.WriteLine(new string('*', 4 * n + 1));





    }
}
