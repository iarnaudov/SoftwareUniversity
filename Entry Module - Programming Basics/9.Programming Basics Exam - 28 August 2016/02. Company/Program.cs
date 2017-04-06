using System;

class Program
{
    static void Main()
    {

        int hoursneeded = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());


        double hoursavailable = (days * 0.90)*8;
        double addHours = workers * 2 * days;
        double TotalHours =Math.Floor(hoursavailable + addHours);
        if (TotalHours>=hoursneeded) Console.WriteLine("Yes!{0} hours left.",TotalHours-hoursneeded);
        else if (hoursneeded > TotalHours) Console.WriteLine("Not enough time!{0} hours needed.", hoursneeded-TotalHours );











    }
}
