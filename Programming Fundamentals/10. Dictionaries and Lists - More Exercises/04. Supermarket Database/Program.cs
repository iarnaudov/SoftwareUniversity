using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> command = Console.ReadLine().Split(' ').ToList();
        var stock = new Dictionary<string, Dictionary<double, int>>();

        var productQuantity = new Dictionary<string, int>();

        while (command[0] != "stocked")
        {
            var product = command[0];
            double price = double.Parse(command[1]);
            var quantity = int.Parse(command[2]);
           

            if (!stock.ContainsKey(product))
            {
                stock[product] = new Dictionary<double, int>();
                stock[product].Add(price, quantity);

                productQuantity[product] = quantity;

            }
            else
            {
                //if the dictionary already contains the given product the quantity increases and the price is changed
                quantity += productQuantity[product];
                productQuantity[product] = quantity;

                //this clears the info from the dict so the new price and quantity to be added
                stock[product].Clear();
                stock[product].Add(price, quantity);
            }
            command = Console.ReadLine().Split(' ').ToList();
        }
        var grandTotal = 0.0;
        foreach (var product in stock)
        {
            foreach (var priceQuant in product.Value)
            {
                var currentTotal = priceQuant.Key * priceQuant.Value;
                grandTotal += currentTotal;
                Console.WriteLine($"{product.Key}: ${priceQuant.Key:f2} * {priceQuant.Value} = ${currentTotal:f2}");
            }
        }
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Grand Total: ${grandTotal:f2}");




    }
}

