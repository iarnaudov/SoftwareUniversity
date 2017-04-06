using System;

class Program
{
    static void Main()
    {
        int FirstSpeed = int.Parse(Console.ReadLine()); 
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine()); 
        int t3 = int.Parse(Console.ReadLine()); ;
            

        double mediumspeed = 0;
        double TotalKM = 0;
        double FirstRow = 0;
        double SecondROw = 0;
        double ThirdRow = 0;


        for (int i = 0; i < 2; i++)
        {
            if (i==0)
            {
                FirstRow = FirstSpeed * (t1 / 60.0);
                    mediumspeed = FirstSpeed+(FirstSpeed*0.1);
            }
            else if (i==1)
            {
                SecondROw = mediumspeed * (t2 / 60.0);
                mediumspeed = mediumspeed - (mediumspeed * 0.05);
            }
            

        }
        ThirdRow = mediumspeed * (t3 / 60.0);
        TotalKM = FirstRow + SecondROw + ThirdRow;
        Console.WriteLine("{0:f2}", TotalKM);


    }
}
