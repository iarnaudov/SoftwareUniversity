using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
static void Main()
{
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine();
            var mostleftSlashIndex = inputLine.IndexOf(@"\");
            string root = "";
            if (mostleftSlashIndex>=0)
            {
                root = inputLine.Substring(0,mostleftSlashIndex);
            }
            Console.WriteLine(root);
           
        }
                        
}
}

