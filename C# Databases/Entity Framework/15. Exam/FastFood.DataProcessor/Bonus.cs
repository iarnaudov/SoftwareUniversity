using System;
using FastFood.Data;
using System.Linq;
using FastFood.Models;

namespace FastFood.DataProcessor
{
    public static class Bonus
    {
	    public static string UpdatePrice(FastFoodDbContext context, string itemName, decimal newPrice)
	    {
                var item = context.Items.Where(i => i.Name == itemName).SingleOrDefault();

                if (item == null)
                {
                    return $"Item {itemName} not found!";
                }
                else
                {
                    var itemPreviousPrice = item.Price;

                    item.Price = newPrice;

                    context.SaveChanges();
                    return $"{itemName} Price updated from ${itemPreviousPrice:F2} to ${newPrice:F2}";
                }
        }
    }
}
