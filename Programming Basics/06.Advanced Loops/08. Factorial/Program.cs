using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int product = 1;
        int counter = 1;

        do
        {    
            product = product * counter;
            counter++;

        } while (counter<=n);
        Console.WriteLine(product);
    }
}
