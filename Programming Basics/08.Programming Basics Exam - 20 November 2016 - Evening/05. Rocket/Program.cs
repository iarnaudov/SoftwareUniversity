using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = ((3 * n) / 2) - 1;
        string spaces = " ";

        // Горните 4 реда
        // ШИРИНАТА e = 3*n
        for (int row = 0; row < n; row++)
        {
            
            dots = dots - row;
            Console.Write(new string('.', dots));
            Console.Write('/');
            Console.Write( new string(' ', row * 2));
            Console.Write('\\');
            Console.WriteLine (new string('.', dots));
            dots = ((3 * n) / 2) - 1;
        }



        // Звездичките
        dots = n / 2;
        Console.Write(new string('.', dots));
        Console.Write(new string('*',n*2));
        Console.WriteLine(new string('.', dots));


        // Тялото на ракетата
        for (int i = 0; i < n*2; i++)
        {
            dots = n / 2;
            Console.Write(new string('.', dots));
            Console.Write('|');
            Console.Write(new string('\\',(n*3)-2-dots*2));
            Console.Write('|');
            Console.WriteLine(new string('.', dots));
        }

        // Последните 2 реда

        for (int i = 0; i < n/2; i++)
        {
            dots = n / 2;
            Console.Write(new string('.', dots-i));
            Console.Write('/');
            Console.Write(new string('*', ((n * 3) - 2 - dots * 2 +i*2)));
            Console.Write('\\');
            Console.WriteLine(new string('.', dots-i));
        }
    }
}
