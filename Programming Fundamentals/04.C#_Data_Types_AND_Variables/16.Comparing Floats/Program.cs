using System;

class Program
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        double result = Math.Abs(a - b);
        if (result>eps)
        {
            Console.WriteLine("False");
        }
        else if (result==eps)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }

    }
}

