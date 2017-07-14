using System;

class Program
{
    static void Main()
    {

        double budget = double.Parse(Console.ReadLine());
        int numberofItems = int.Parse(Console.ReadLine());
        double Subtotal = 0;

        for (int i = 0; i < numberofItems; i++)
        {
            string ItemName = Console.ReadLine();
            double ItemPrice = double.Parse(Console.ReadLine());
            int ItemCount = int.Parse(Console.ReadLine());
            if (ItemCount>1)
            {
                Console.WriteLine($"Adding {ItemCount} {ItemName}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {ItemCount} {ItemName} to cart.");
            }
            double total = ItemPrice * ItemCount;
            Subtotal += total;
        }
        Console.WriteLine($"Subtotal: ${Subtotal:f2}");
        if ((budget-Subtotal)>=0)
        {
            Console.WriteLine("Money left: ${0:f2}", budget - Subtotal);
        }
        else if ((budget - Subtotal) < 0)
        {
            Console.WriteLine("Not enough. We need ${0:f2} more.", Math.Abs(budget - Subtotal));
        }
      




    }
}

