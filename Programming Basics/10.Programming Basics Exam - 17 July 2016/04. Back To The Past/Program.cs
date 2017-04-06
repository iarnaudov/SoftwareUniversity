using System;

class Program
{
    static void Main()
    {

        double money = double.Parse(Console.ReadLine());
        int startyear = 1800;
        int year = int.Parse(Console.ReadLine());
        int counter = 18;
        double MoneyLeft = 0;

        for (int i = startyear; i <= year; i++)
        {
            
            if (i%2==0)
            {
                MoneyLeft = money - 12000;
               
            }
            else
            {
                MoneyLeft = money - (12000 + 50 * counter);
            }
            counter++;

            money = MoneyLeft;

            
        }
        if (MoneyLeft>=0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", MoneyLeft);
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.", MoneyLeft*-1);
        }
        
















    }
}
