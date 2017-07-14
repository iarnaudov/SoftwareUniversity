using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseString
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int mostFrequentNumbr = 0;
        int repetitions = 0;
        //int number = 0; // вариант 1 70/100
        //int numberPos = 0; // вариант 2 80/100

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int counter = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if (currentNumber == numbers[j])
                {
                    //numberPos = index - counter; // вариант 2 80/100
                    counter++;
                }

            }

            if (counter > repetitions)
            {
                mostFrequentNumbr = currentNumber;
                repetitions = counter;
                //number = numbers[i]; // вариант 1 - 70/100 
            }
        }

        //Console.WriteLine(longest);
        //Console.WriteLine(numberPos);

        Console.WriteLine("{0}", mostFrequentNumbr); // вариант 1 - 70/100
        //Console.WriteLine("{0}", numbers[numberPos]); // вариант 2 - 80/100
    }
}