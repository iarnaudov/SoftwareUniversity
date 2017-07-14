using System;

class Program
{
    static void Main()
    {
        string name = AskName();
        Console.WriteLine("Hello, {0}!", name);
    }

     static string AskName()
    {
       string name = Console.ReadLine();
       return name;
    }
}

