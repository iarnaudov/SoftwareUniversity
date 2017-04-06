using System;

class Program
{
    static void Main()
    {

        double Budjet = double.Parse(Console.ReadLine());
        string TypeGame = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        double MoneyLeft = 0;



        switch (TypeGame)
        {
            case "Normal":
                if (n>=1 && n<=4) MoneyLeft= Budjet - (Budjet * 0.75) - (n * 249.99);
                else if (n >= 5 && n <= 9) MoneyLeft = Budjet - (Budjet * 0.6) - (n * 249.99);
                else if (n >= 10 && n <= 24) MoneyLeft = Budjet - (Budjet * 0.5) - (n * 249.99);
                else if (n >= 25 && n <= 49) MoneyLeft = Budjet - (Budjet * 0.4) - (n * 249.99);
                else if (n >= 50 ) MoneyLeft = Budjet - (Budjet * 0.25) - (n * 249.99); break;


            case "VIP":
                if (n >= 1 && n <= 4) MoneyLeft = Budjet - (Budjet * 0.75) - (n * 499.99);
                else if (n >= 5 && n <= 9) MoneyLeft = Budjet - (Budjet * 0.6) - (n * 499.99);
                else if (n >= 10 && n <= 24) MoneyLeft = Budjet - (Budjet * 0.5) - (n * 499.99);
                else if (n >= 25 && n <= 49) MoneyLeft = Budjet - (Budjet * 0.4) - (n * 499.99);
                else if (n >= 50) MoneyLeft = Budjet - (Budjet * 0.25) - (n * 499.99); break;



            default:
                break;
        }
        if (MoneyLeft>=0) Console.WriteLine("Yes! You have {0:f2} leva left.", MoneyLeft );
        else if (MoneyLeft < 0) Console.WriteLine("Not enough money! You need {0:f2} leva.", MoneyLeft*-1 );

















    }
}
