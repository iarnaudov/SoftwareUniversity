using System;

class Program
{
    static void Main()
    {

        char n = char.Parse(Console.ReadLine());
        if (n == 'a' || n == 'e' || n == 'o' || n == 'u' || n == 'i')
        {
            Console.WriteLine("vowel");
        }
        else if (char.IsNumber(n))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
       
    }
}

