using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        //while (true)
        //{
        //    string resource = Console.ReadLine();
        //    string quantity = Console.ReadLine();
        //    if (resource == "stop") { break; }
        //    Console.WriteLine($"{resource} -> {quantity}");
        //}

        var miner = new Dictionary<string, int>();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "stop") { break; }
            else
            {
                if (miner.ContainsKey(command))
                {
                    miner[command] += int.Parse(Console.ReadLine());
                }
                else
                {
                    miner[command] = int.Parse(Console.ReadLine());
                }
               
            }
          
        }
        miner.ToList().ForEach(x => Console.WriteLine("{0} -> {1}", x.Key, x.Value));




    }
}

