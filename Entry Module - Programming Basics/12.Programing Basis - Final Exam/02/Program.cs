using System;

class Program
{
    static void Main()
    {

        int hours = int.Parse(Console.ReadLine()) ;
        int workers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        double TotalHoursNeeded = workers * days * 8;

        if (TotalHoursNeeded>hours)
        {
            Console.WriteLine("{0} hours left",TotalHoursNeeded-hours);
        }
        if (TotalHoursNeeded<=hours)
        {
            Console.WriteLine("{0} overtime", hours - TotalHoursNeeded);
            double penalties = (hours - TotalHoursNeeded) * days;
            Console.WriteLine("Penalties: {0}", penalties);
        }















    }
}
