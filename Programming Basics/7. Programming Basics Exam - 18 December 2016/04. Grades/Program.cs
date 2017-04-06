using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double counterAbove5 = 0;
        double counter4and5 = 0;
        double counter3and4 = 0;
        double counter2and3 = 0;
        double AverageGrades = 0;

        for (int i = 0; i < n; i++)
        {
            double grades = double.Parse(Console.ReadLine());
            AverageGrades += grades;

            if (grades >= 5.00) counterAbove5++;
            else if (grades >= 4.00 && grades < 5.00) counter4and5++;
            else if (grades >= 3.00 && grades < 4.00) counter3and4++;
            else if (grades >= 2.00 && grades < 3.00) counter2and3++;
        }
      
        Console.WriteLine("Top students: {0:f2}%", counterAbove5/n*100);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", counter4and5 / n*100);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", counter3and4 / n*100);
        Console.WriteLine("Fail: {0:f2}%", counter2and3 / n*100);
        Console.WriteLine("Average: {0:f2}", AverageGrades / n);
    }
}
