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
        var distance = Console.ReadLine().Split().Select(int.Parse).ToList();
        var sumElements = 0;
        var removedElement = 0;


        while (distance.Count != 0)
        {
            int index = int.Parse(Console.ReadLine());
            if (index<0)
            {
                sumElements += distance[0];
                removedElement = distance[0];
                distance[0] = distance.Last();
                //distance.RemoveAt(distance.Count - 1);
                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= removedElement)
                    {
                        distance[i] += removedElement;
                    }
                    else
                    {
                        distance[i] -= removedElement;
                    }
                }
            }
            else if (index > distance.Count - 1)
            {
                sumElements += distance[distance.Count - 1];
                removedElement = distance[distance.Count - 1];
                //  distance.RemoveAt(distance.Count - 1);
                distance[distance.Count - 1] = distance[0];
                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= removedElement)
                    {
                        distance[i] += removedElement;
                    }
                    else
                    {
                        distance[i] -= removedElement;
                    }
                }

            }
                else if (index >= 0 && index <= distance.Count - 1)
                {
                    sumElements += distance[index];
                    removedElement = distance[index];
                    distance.RemoveAt(index);
                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (distance[i] <= removedElement)
                        {
                            distance[i] += removedElement;
                        }
                        else
                        {
                            distance[i] -= removedElement;
                        }
                    }
                }
        }
        Console.WriteLine(sumElements);
    }
}

