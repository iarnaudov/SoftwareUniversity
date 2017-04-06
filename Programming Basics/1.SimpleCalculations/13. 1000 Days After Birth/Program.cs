using System;

class Program
{
    static void Main()
    {
        string InputDate = Console.ReadLine();
        string format = "dd-MM-yyyy";
        DateTime date = DateTime.ParseExact(InputDate, format, System.Globalization.CultureInfo.InvariantCulture);
        date = date.AddDays(999);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));
    }
}
