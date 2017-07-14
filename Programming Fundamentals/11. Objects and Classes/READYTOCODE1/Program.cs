using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        string word = "Banana";

        var result = Enumerable.Repeat(word, 5);

        Console.WriteLine("String is repeated 5 times:");
        foreach (string str in result)
            Console.WriteLine(str);
    }
}