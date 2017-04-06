using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine(num2);
        }
        else if (num1 == num2)
        {
            Console.WriteLine(num1);
        }

    }
}
