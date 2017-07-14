using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[] prices = Console.ReadLine().Split().Select(double.Parse).ToArray(); // price of jewels and gold
        double priceJewels = prices[0];
        double priceGold = prices[1];
        string lootStr = Console.ReadLine();

        double income = 0;
        double totalExpenses = 0;
        double jewelsCounter = 0;
        double goldCounter = 0;

        while (lootStr != "Jail Time")
        {
             
            if (lootStr != "Jail Time")
            {
                string[] loot = lootStr.Split();
                string characters = loot[0];
                double expenses = double.Parse(loot[1]);

                char[] charLoot = characters.ToCharArray();

                totalExpenses += expenses;

                for (int i = 0; i < charLoot.Length; i++)
                {
                    if (charLoot[i] == '%')
                    {
                        jewelsCounter++;
                    }
                    else if (charLoot[i] == '$')
                    {
                        goldCounter++;
                    }
                }
                lootStr = Console.ReadLine();
            }
            else
            {
                continue;
            }
           
        }
        income = (jewelsCounter * priceJewels) + (goldCounter * priceGold);
        if (income>totalExpenses)
        {
            Console.WriteLine("Heists will continue. Total earnings: {0}.", income-totalExpenses);
        }
        else if (income<totalExpenses)
        {
            Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses-income);

        }





    }
}

