using System;

class Program
{
    static void Main()
    {
        int dni =int.Parse(Console.ReadLine());
        double wage = double.Parse(Console.ReadLine());
        double ExchangeRate = double.Parse(Console.ReadLine());
        double Totalsum = 0;
        double TotalMonth = 0;
        double TotalDay = 0;
        double TotalDayInLv = 0; 

        TotalMonth = dni * wage;
        Totalsum = (TotalMonth * 12 + TotalMonth * 2.5)*0.75;
        TotalDay = Totalsum / 365;
        TotalDayInLv = TotalDay * ExchangeRate;
        Console.WriteLine("{0:f2}", TotalDayInLv);

        
















    }
}
