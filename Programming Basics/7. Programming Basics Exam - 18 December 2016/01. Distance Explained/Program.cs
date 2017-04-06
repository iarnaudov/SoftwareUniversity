using System;

class Program
{
    static void Main()
    {
        int InitialSpeed = int.Parse(Console.ReadLine());
        int FirstTime = int.Parse(Console.ReadLine());
        int SecondTime = int.Parse(Console.ReadLine());
        int Thirdtime = int.Parse(Console.ReadLine());


        double speed = InitialSpeed;
        double s1 = speed * FirstTime / 60.0;
        speed = speed * 1.1;
        double s2 = speed * SecondTime / 60.0;
        speed = speed * 0.95;
        double s3 = speed * Thirdtime / 60.0;

        Console.WriteLine("{0:0.00}", s1 + s2 + s3);



    }
}
