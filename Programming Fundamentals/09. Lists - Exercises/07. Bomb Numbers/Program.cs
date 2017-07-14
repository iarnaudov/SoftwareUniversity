using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {



            var currentNum = list[i];

            if (bomb[0] == list[i])
            {
                var leftIndex = Math.Max(i - bomb[1], 0);
                var rightIndex = Math.Max(i + bomb[1], list.Count - 1);

                var removeCount =rightIndex- leftIndex + 1;
                list.RemoveRange(leftIndex, removeCount);
                i = -1;
            }
        }
        Console.WriteLine(list.Sum());


    }
}

