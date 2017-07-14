using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        int guestsNum = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        var portions = Math.Ceiling(guestsNum / 6.0);
        var portionPrice = (2 * bananaPrice) + (4 * eggPrice) + (0.2m * berriesPrice);
        var totalPrice = portionPrice * (decimal)portions;

        if (budget>=totalPrice)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalPrice - budget);
        }

    }
}

