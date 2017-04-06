using System;

class Program
{
    public static object ReadAllLines { get; private set; }

    static void Main()
    {
        int n = 9;
        int startStars = 2 - n % 2;
        int topRows = (n + 1) / 2;
        int lowRows = n - topRows;

        // Top row
        int startDashes = (n - startStars) / 2;

        Console.Write(new string('-', startDashes));
        Console.Write(new string('*', startStars));
        Console.WriteLine(new string('-', startDashes));

        //Top Other rows
        for (int i = 0; i < topRows - 1; i++)
        {
            int insideDashes = startStars + i * 2;
            int outerDashes = (n - 2 - insideDashes) / 2;
            Console.Write(new string('-', outerDashes));
            Console.Write('*');
            Console.Write(new string('-', insideDashes));
            Console.Write('*');
            Console.WriteLine(new string('-', outerDashes));
        }
        var counte = ReadAllLines;
        Console.WriteLine(counte);

        //////Low Rows
        //for (int i = 0; i < topRows - 2; i--)
        //{
        //    int insideDashes = startStars + i * 2;
        //    int outerDashes = (n - 2 - insideDashes) / 2;
        //    Console.Write(new string('-', outerDashes));
        //    Console.Write('*');
        //    Console.Write(new string('-', insideDashes));
        //    Console.Write('*');
        //    Console.WriteLine(new string('-', outerDashes));

        //}

    }
}
