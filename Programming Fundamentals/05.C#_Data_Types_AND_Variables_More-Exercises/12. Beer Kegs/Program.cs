using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double maxSize = 0;
        string finalModel = "";
        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double size = Math.PI * Math.Pow(radius, 2) * height;
            if (maxSize<size)
            {
                finalModel = model;
                maxSize = size;
            }

            

        }
        Console.WriteLine(finalModel);




    }
}

