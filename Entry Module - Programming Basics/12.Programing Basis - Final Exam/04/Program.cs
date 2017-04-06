using System;

class Program
{
    static void Main()
    {


        int n = int.Parse(Console.ReadLine());
        double InvalidNum = 0;
        double ToNinenum = 0;
        double ToNineteennum = 0;
        double ToTwentyNinenum = 0;
        double TotThirtyNineNum = 0;
        double ToFiftyNum = 0;
        double TotalScore = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0 || input > 50)
            {
                InvalidNum++;
                TotalScore -= TotalScore / 2;
            }
            else if (input >= 0 && input <= 9)
            {
                ToNinenum++;
                TotalScore += input * 0.2;
            }
            else if (input >= 10 && input <= 19)
            {
                ToNineteennum++;
                TotalScore += input * 0.3;
            }
            else if (input >= 20 && input <= 29)
            {
                ToTwentyNinenum++;
                TotalScore += input * 0.4;
            }
            else if (input >= 30 && input <= 39)
            {
                TotThirtyNineNum++;
                TotalScore += 50;
            }
            else if (input >= 40 && input <= 50)
            {
                ToFiftyNum++;
                TotalScore += 100;
            }
            

        }
        double Percents = InvalidNum + ToNinenum + ToNineteennum + ToTwentyNinenum + TotThirtyNineNum + ToFiftyNum;
        Console.WriteLine("{0:f2}",TotalScore);
        Console.WriteLine("From 0 to 9: {0:0.00}%", ToNinenum/Percents*100);
        Console.WriteLine("From 10 to 19: {0:0.00}%", ToNineteennum / Percents*100);
        Console.WriteLine("From 20 to 29: {0:0.00}%", ToTwentyNinenum / Percents*100);
        Console.WriteLine("From 30 to 39: {0:0.00}%", TotThirtyNineNum / Percents*100);
        Console.WriteLine("From 40 to 50: {0:0.00}%", ToFiftyNum / Percents*100);
        Console.WriteLine("Invalid numbers: {0:0.00}%", InvalidNum / Percents*100);
        












    }
}
