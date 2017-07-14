using System;
using System.Linq;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var allIngredients = Console.ReadLine().Split(' ');
            var stringLenght = long.Parse(Console.ReadLine());

            var ingredientsCount = 0;

            var pizzaIngredients = new string[allIngredients.Length];

            foreach (var ingredient in allIngredients)
            {
                if (ingredient.Length == stringLenght)
                {
                    pizzaIngredients[ingredientsCount] = ingredient;
                    ingredientsCount++;
                    Console.WriteLine($"Adding {ingredient}.");

                    if (ingredientsCount == 10)
                    {
                        break;
                    }
                }
            }
            pizzaIngredients = pizzaIngredients.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", pizzaIngredients));

        }
    }
}