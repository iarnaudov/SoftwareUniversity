using System;

class Program
{
    static void Main()
    {

        
        try
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("integer");
        }
        catch (System.FormatException)
        {

            Console.WriteLine("floating-point");
        }
        



    }
}

