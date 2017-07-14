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
        var n = int.Parse(Console.ReadLine());
        decimal totalPrice = 0.0m;

        for (int i = 0; i < n; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            string[] date = Console.ReadLine().Split('/');
            var month = int.Parse(date[1]);
            var year = int.Parse(date[2]);
           var  capsulesCount = int.Parse(Console.ReadLine());
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var price = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");



    }
}

