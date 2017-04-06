using System;

class Program
{
    static void Main()
    {
        string pass = Console.ReadLine();
        string secret = "s3cr3t!P@ssw0rd";

        if (pass == secret)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
