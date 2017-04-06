using System;

class Program
{
    static void Main()
    {
        Console.Title = "Programka za 4islata brat";


        Console.WriteLine("Еnter a number in the range [1...100]: ");
        int n = int.Parse(Console.ReadLine());

        while (n<1 || n>100)
        {        
            Console.WriteLine("Invalid number!");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number is {0}",n);

       


    }
}
