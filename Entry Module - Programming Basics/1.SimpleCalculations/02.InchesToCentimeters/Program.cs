using System;

namespace InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main()
        {
            Console.Write("Enter Inches: ");
            var inch = double.Parse(Console.ReadLine());
            var cents = inch * 2.54;
            Console.Write("Centimeters = {0}", cents);
            Console.WriteLine();
        }
    }
}
