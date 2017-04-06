using System;

class Program
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        if (sales >= 0)
        {
            switch (town)
            {
                case "sofia":
                    if (0<=sales && sales<=500) {Console.WriteLine("{0:f2}", sales*0.05);}
                    else if (500 < sales && sales <= 1000) { Console.WriteLine("{0:f2}", sales * 0.07); } 
                    else if (1000 < sales && sales <= 10000) { Console.WriteLine("{0:f2}", sales * 0.08); }
                    else if (sales>10000) { Console.WriteLine("{0:f2}",sales * 0.12); } break;
                case "varna":
                    if (0 <= sales && sales <= 500) { Console.WriteLine("{0:f2}", sales * 0.045); } 
                    else if (500 < sales && sales <= 1000) { Console.WriteLine("{0:f2}", sales * 0.075); }
                    else if (1000 < sales && sales <= 10000) { Console.WriteLine("{0:f2}", sales * 0.1); } 
                    else if (sales > 10000) { Console.WriteLine("{0:f2}", sales * 0.13); } break;
                case "plovdiv":
                    if (0 <= sales && sales <= 500) { Console.WriteLine("{0:f2}", sales * 0.055); } 
                    else if (500 < sales && sales <= 1000) { Console.WriteLine("{0:f2}", sales * 0.08); }
                    else if (1000 < sales && sales <= 10000) { Console.WriteLine("{0:f2}", sales * 0.12); }  
                    else if (sales > 10000) { Console.WriteLine("{0:f2}", sales * 0.145); } break;
                default: Console.WriteLine("error"); break;
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
