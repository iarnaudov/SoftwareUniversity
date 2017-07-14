using System;

class Program
{
    static void Main()
    {

        char FirstSymbol = Char.Parse(Console.ReadLine());
        char secondSymbol = Convert.ToChar(Console.ReadLine());
        char skipSymbol = Convert.ToChar(Console.ReadLine());
        int counter = 0;

        for (char symbol1 = FirstSymbol; symbol1 <= secondSymbol; symbol1++)
        {
            if (symbol1 == skipSymbol)
            {
                continue;
            }
            for (char symbol2 = FirstSymbol; symbol2 <= secondSymbol; symbol2++)
            {
                if (symbol2 == skipSymbol)
                {
                    continue;
                }
                for (char symbol3 = FirstSymbol; symbol3 <= secondSymbol; symbol3++)
                {
                    if (symbol3 == skipSymbol)
                    {
                        continue;
                    }
                    else
                    {


                        counter++;
                        string currentOutput = symbol1.ToString()
                            + symbol2.ToString() + symbol3.ToString();
                        Console.Write("{0} ", currentOutput);


                    }
                }
            }
        }

    }
}
