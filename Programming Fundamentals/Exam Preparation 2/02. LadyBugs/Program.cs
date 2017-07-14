using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());
        var ladyBugIndexes = Console.ReadLine()
            .Split().Select(int.Parse)
            .Where(a => a>=0 && a<fieldSize).ToArray();

        var ladybugs = new int[fieldSize];

        foreach (var ladyBugIndex in ladyBugIndexes)
        {
            ladybugs[ladyBugIndex] = 1;
        }

        while (true)
        {
            var line = Console.ReadLine();
            if (line == "end"){break;}

            var tokens = line.Split();
            var ladybugIndex = int.Parse(tokens[0]);
            var direction = tokens[1];
            var count = int.Parse(tokens[2]);

            var isInsideArray = ladybugIndex > 0 && ladybugIndex < ladybugs.Length;

            if (!isInsideArray)
            {
                continue;
            }

            var ladybugExists = ladybugs[ladybugIndex] == 1;
            if (!ladybugExists)
            {
                continue;
            }
            MoveLadyBug(ladybugs, ladybugIndex, direction, count);
        }
        Console.WriteLine(string.Join(" ", ladybugs));
    }

     static void MoveLadyBug(int[] ladybugs, int ladybugIndex, string direction, int count)
    {
        if (direction == "left")
        {
            count = -count;
        }
        var nextIndex = ladybugIndex + count;
        ladybugs[ladybugIndex] = 0;
        var hasLeftArrayOfFoundPlace = false;
        while (!hasLeftArrayOfFoundPlace)
        {
            if (nextIndex<0 || nextIndex > ladybugs.Length-1)
            {
                hasLeftArrayOfFoundPlace = true;
                continue;
            }
            var ladybugExistsOnIndex = ladybugs[nextIndex] == 1;
            if (ladybugExistsOnIndex)
            {
                nextIndex += count;
                continue;
            }
            ladybugs[nextIndex] = 1;
            hasLeftArrayOfFoundPlace = true;
        }
    }
}

