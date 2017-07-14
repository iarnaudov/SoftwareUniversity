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
        decimal total = 0;
        int orders = int.Parse(Console.ReadLine());
        for (int i = 0; i < orders; i++)
        {
            decimal price = decimal.Parse(Console.ReadLine());
            var input = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var month = input.Month;
            var year = input.Year;
            var daysInMonth = DateTime.DaysInMonth(year, month);
            int capsulesCount = int.Parse(Console.ReadLine());
            var coffeePrice = (daysInMonth * capsulesCount) * price;
            total += coffeePrice;
            Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
        }
        Console.WriteLine($"Total: ${total:F2}");
    }
}

