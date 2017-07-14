using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int dots = 1;
        ////Top part
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(' ', i));
            Console.Write(new string('x', 1));
            Console.Write(new string(' ', (n - 2)-counter));
            Console.Write(new string('x', 1));
            Console.Write(new string(' ', i));
            Console.WriteLine();
            counter += 2;
        }
        Console.Write(new string(' ', n/2));
        Console.Write(new string('x', 1));
        Console.Write(new string(' ', n / 2));
        Console.WriteLine();
        //bottom part
        for (int i = n/2; i > 0; i--)
        {
            
            Console.Write(new string(' ', i-1));
            Console.Write(new string('x', 1));
            Console.Write(new string(' ', dots));
            Console.Write(new string('x', 1));
            Console.Write(new string(' ', i - 1));
            Console.WriteLine();
             dots+=2;
        }





    }
}

