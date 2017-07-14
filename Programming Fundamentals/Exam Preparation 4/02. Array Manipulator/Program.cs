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
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (true)
        {
            var command = Console.ReadLine().Split();
            if (command[0] == "end") { break; }
           else if (command[0] == "exchange")
            {
                int index = int.Parse(command[1]);
                if (index > array.Length && index<=0) { Console.WriteLine("Invalid index"); continue; }
                var lastDigitsArray = array.Skip(index + 1);
                var firstDigitsArray = array.Take(index + 1);
                array = lastDigitsArray.Concat(firstDigitsArray).ToArray();
            }

            else if (command[0] == "max" || command[0] == "min")
            {
                var evenOrOdd = command[1];
                if (evenOrOdd == "odd")
                {
                    if (command[0]=="max")
                    {
                        int max = 0;
                        try
                        {
                             max = array.Where(a => a % 2 != 0).ToArray().Max();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        } 
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == max)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else if (command[0] == "min")
                    {
                        int min = 0;
                        try
                        {
                            min = array.Where(a => a % 2 != 0).ToArray().Min();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == min)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
                if (evenOrOdd =="even")
                {
                    if (command[0] == "max")
                    {
                        int max = 0;
                        try
                        {
                            max = array.Where(a => a % 2 == 0).ToArray().Max();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == max)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else if (command[0] == "min")
                    {
                        int min = 0;
                        try
                        {
                            min = array.Where(a => a % 2 == 0).ToArray().Min();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == min)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }

            else if (command[0] == "first" || command[0] == "last")
            {
                int index = int.Parse(command[1]);
                if (index > array.Length) { Console.WriteLine("Invalid count"); continue; }
                var evenOrOdd = command[2];
                if (evenOrOdd == "odd")
                {
                    if (command[0] == "first")
                    {
                        var newarray = array.Where(a => a % 2 != 0).Take(index).ToArray();
                        if (array.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        Console.WriteLine($"[{string.Join(", ", newarray)}]");
                    }
                    else if (command[0]=="last")
                    {
                        var newarray = array.Reverse().Where(a => a % 2 != 0).Take(3).Reverse().ToArray();
                        if (array.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        Console.WriteLine($"[{string.Join(", ", newarray)}]");
                    }
                 
                }
                else if (evenOrOdd == "even")
                {
                    if (command[0] == "first")
                    {
                       var newarray = array.Where(a => a % 2 == 0).Take(index).ToArray();
                        if (array.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        Console.WriteLine($"[{string.Join(", ", newarray)}]");
                    }
                    else if (command[0] == "last")
                    {
                        var newarray = array.Reverse().Where(a => a % 2 == 0).Take(3).Reverse().ToArray();
                        if (array.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        Console.WriteLine($"[{string.Join(", ", newarray)}]");
                    }

                }

            }
        }

        Console.WriteLine($"[{string.Join(", ",array)}]");


    }
}

