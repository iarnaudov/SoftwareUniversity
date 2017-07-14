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
        string[] items = Console.ReadLine().Split();

        while (true)
        {
            var commandLine = Console.ReadLine().ToLower().Trim();
            if (commandLine == "end"){break;}
            var commandParts = commandLine.Split();
            var commandName = commandParts[0];
            ProcessCommand(items, commandName, commandParts);
        }
        Console.WriteLine($"[{string.Join(", ",items)}]");

    }

    private static void ProcessCommand(string[] items,string cmd, string[] cmdParts)
    {
       
        if (cmd == "sort" || cmd == "reverse")
        {
            var start = int.Parse(cmdParts[2]);
            var count = int.Parse(cmdParts[4]);
            if (start<0 || start>items.Length-1 || (start + count) - 1<0 || (start+count)-1> items.Length - 1 || count<0)
            {
                Console.WriteLine("Invalid input parameters");
                return;
            }
            if (cmd == "sort")
            {
                SortRange(items, start, count);
            }
            else if (cmd == "reverse")
            {
                ReverseRange(items, start, count);
            }
        }
        if (cmd == "rollleft" || cmd == "rollright")
        {
            int count = int.Parse(cmdParts[1]);
            if (count<0)
            {
                Console.WriteLine("Invalid input parameters");
                return;
            }
            if (cmd == "rollleft")
            {
                RollRight(items, -count);
            }
            if (cmd == "rollright")
            {
                RollRight(items, count);
            }
        }
        
    }

    private static void ReverseRange(string[] items, int start, int count)
    {
        var end = start + count - 1;
        while (start < end)
        {
            var oldItem = items[start];
            items[start] = items[end];
            items[end] = oldItem;
            start++;
            end--;
        }
    }

    private static void RollRight(string[] items, int count)
    {
        var result = new string[items.Length];
        for (int oldIndex = 0; oldIndex < items.Length; oldIndex++)
        {
            var newIndex = oldIndex + count;
            newIndex = newIndex % items.Length;
            if (newIndex < 0)
            {
                newIndex += items.Length;
                result[newIndex] = items[oldIndex];
            }
        }
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = result[i];
        }
    }

    private static void SortRange(string[] items, int start, int count)
    {
        Array.Sort(items, start, count);
    }
}

