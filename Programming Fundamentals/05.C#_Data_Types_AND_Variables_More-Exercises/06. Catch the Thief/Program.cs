using System;

class Program
{
    static void Main()
    {
        string numType = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        long maxID = long.MinValue;

        for (int i = 0; i < n; i++)
        {
            long id = long.Parse(Console.ReadLine());
            switch (numType)
            {
                case "sbyte":
                    if (id > maxID && id <= sbyte.MaxValue)
                    {
                        maxID = id;
                    }break;
                case "int":
                    if (id > maxID && id <= int.MaxValue)
                    {
                        maxID = id;
                    }
                    break;
                case "long":
                    if (id > maxID && id <= long.MaxValue)
                    {
                        maxID = id;
                    }
                    break;
                default: break;
            }
           
        }
        Console.WriteLine(maxID);





    }
}

