using System;

class Program
{
    static void Main()
    {
        int BitCoins = int.Parse(Console.ReadLine());
        double Uan =double.Parse(Console.ReadLine());
        double Commision = double.Parse(Console.ReadLine());
        double TotalBitCouinsinLv = 0;
        double TotalUansinLV = 0;

        TotalBitCouinsinLv = BitCoins * 1168;
        TotalUansinLV = (Uan * 0.15) * 1.76;
        double TotalLv = TotalUansinLV + TotalBitCouinsinLv;
        double TotalEuro = TotalLv / 1.95;
        double TotalCommision = TotalEuro - (TotalEuro * Commision / 100);
        Console.WriteLine(TotalCommision);
       















    }
}
