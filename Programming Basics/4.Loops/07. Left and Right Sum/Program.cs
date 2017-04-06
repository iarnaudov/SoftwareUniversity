using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++) //leftsums
        {
            int inputNumber = int.Parse(Console.ReadLine());
            leftSum += inputNumber;
            
        }

        for (int i = 0; i < n; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            rightSum += inputNumber;
            
        }


        if (leftSum==rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", rightSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSum-rightSum));
        }

    }
}
