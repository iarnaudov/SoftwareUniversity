using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var emailbook = new Dictionary<string, string>();
        


        while (true)
        {
            string name = Console.ReadLine();
            if (name == "stop") { break; }
            string eMail = Console.ReadLine();
            if (eMail.EndsWith("uk") || eMail.EndsWith("us"))
            {
                continue;
            }
            else
            {
                emailbook[name] = eMail;
            }
            
        }
        emailbook.ToList().ForEach(x => Console.WriteLine("{0} -> {1}", x.Key, x.Value));
      
    }
}

