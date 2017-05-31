using System;

public class Program
{
    public static void Main()
    {
        var ingridient = Console.ReadLine();
        var ingridientCount = 0;

        while (ingridient != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingridient}.");
            ingridientCount++;
            ingridient = Console.ReadLine();
        }
        Console.WriteLine($"Preparing cake with {ingridientCount} ingredients.");
    }
}