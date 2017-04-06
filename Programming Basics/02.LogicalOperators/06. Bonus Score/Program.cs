using System;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        double bonus = 0;
        if (num1 <= 100)
        {
            bonus = bonus + 5;
        }
        else if (num1 > 100 && num1 <= 1000)
        {
            bonus = num1 * 0.2;
        }
        else if (num1 > 1000)
        {
            bonus = num1 * 0.1;
        }
        // Extra Bonus Points
        if (num1 % 2 == 0)
        {
            bonus = bonus + 1;
        }
        else if (num1 % 10 == 5)
        {
            bonus = bonus + 2;
        }
        Console.WriteLine(bonus);
        Console.WriteLine(num1 + bonus);


    }
}
