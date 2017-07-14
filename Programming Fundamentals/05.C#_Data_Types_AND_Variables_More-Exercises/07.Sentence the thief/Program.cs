using System;

class Program
{
    static void Main()
    {
        string numType = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        long maxID=long.MinValue;

        for (int i = 0; i < n; i++)
        {
            long id = long.Parse(Console.ReadLine());
            switch (numType)
            {
                case "sbyte":
                    if (id > maxID && id <= sbyte.MaxValue)
                    {
                        maxID = id;
                    }
                    continue;
                case "int":
                    if (id > maxID && id <= int.MaxValue)
                    {
                        maxID = id;
                    }
                    continue;
                case "long":
                    if (id > maxID && id <= long.MaxValue)
                    {
                        maxID = id;
                    }
                    continue;
                default: continue;
            }

        }


        if (maxID<0)
        {
            double years = Math.Ceiling((double)maxID / sbyte.MinValue);
            if (years == 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", maxID, years);
            }
            else
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", maxID, years);
            }

        }
        if (maxID > 0)
        {
            double years = Math.Ceiling((double)maxID / sbyte.MaxValue);
            if (years==1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", maxID, years);
            }
            else
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", maxID, years);
            }
          
        }



    }
}


