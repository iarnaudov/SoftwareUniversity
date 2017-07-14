using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_MoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(' '); // same
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray(); // same

            while (true)
            {
                string[] inputName = Console.ReadLine().Split();
                //От инпута ти идва "Bread 10" няма как да го парснеш към лонг

                if (inputName[0] == "done") // край на цикъла
                {
                    break;
                }
                //вземаш 2рия елемент от масива и го парсваш 
                long inputQuantity = long.Parse(inputName[1]);



                int index = Array.IndexOf(name, inputName[0]); //индекс на търсения елемент
                int quantityL = quantity.Length;

                if (index >= quantityL) // ако няма индекса на дадения елемент в quantity,го приравняваме на 0
                {
                    quantity = new long[quantityL + index];
                    for (int i = 0; i < quantityL; i++)
                    {
                        quantity[quantityL - 1 + i] = 0;
                    }
                }

                // изчисляваме количеството
                if (quantity[index] >= inputQuantity)
                {
                    decimal totalPrice = (decimal)price[index] * inputQuantity;
                    quantity[index] -= inputQuantity;
                    Console.WriteLine($"{inputName[0]} x {inputQuantity} costs {totalPrice:F2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {inputName[0]}");
                }


            }

        }
    }
}