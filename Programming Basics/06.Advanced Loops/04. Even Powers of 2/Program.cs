﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i <= n; i+=2)
        {

            Console.WriteLine(sum);
            sum = sum * 2*2;
        }


    }
}
