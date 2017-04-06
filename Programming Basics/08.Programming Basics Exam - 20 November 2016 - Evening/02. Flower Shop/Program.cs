using System;

class Program
{
    static void Main()
    {
        int Magnolii = int.Parse(Console.ReadLine());
        int Zumbuli = int.Parse(Console.ReadLine());
        int Rozi = int.Parse(Console.ReadLine());
        int Kaktusi = int.Parse(Console.ReadLine());
        double MoneyNeeded = double.Parse(Console.ReadLine());

        double Profit = (Magnolii * 3.25 + Zumbuli * 4 + Rozi * 3.50 + Kaktusi * 8) * 0.95;
        if (MoneyNeeded>Profit)
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(MoneyNeeded-Profit));
            
        }
        else
        {
            Console.WriteLine("She is left with {0} leva.", Math.Floor(Profit-MoneyNeeded));
        }





    }
}
