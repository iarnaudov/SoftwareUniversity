using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            while (true)
            {
                string command = Console.ReadLine();

                string[] comands = command.Split(' ');
                if (comands[0] == "Replace")
                {
                    command = "Replace";
                }

                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(text);
                        break;
                    case "Distinct":
                        text = Distinct(text);
                        break;
                    case "Replace":
                        int indexOfElem = int.Parse(comands[1]);
                        if (indexOfElem>text.Length-1 || indexOfElem<0)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }

                        string newElement = comands[2];
                        text[indexOfElem] = newElement;
                        break;
                    case "END": Console.Write(string.Join(", ", text));
                        Console.WriteLine(); return;
                    default:
                        Console.WriteLine("Invalid input!");
                        continue;
                }
            }
            Console.Write(string.Join(", ", text));
            Console.WriteLine();
        }

        static string[] Distinct(string[] text)
        {
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (text[i] == text[j])
                    {
                        foundDup = true;
                        numDups++;
                        break;
                    }
                }
                if (foundDup == false)
                {
                    text[prevIndex] = text[i];
                    prevIndex++;
                }
            }

            string[] distinctArry = new string[text.Length - numDups];

            for (int i = 0; i < distinctArry.Length; i++)
            {
                distinctArry[i] = text[i];
            }
            return distinctArry;
        }

        static string[] Replace(int indexOfElem, string newElement, string[] text)
        {
            text[indexOfElem] = newElement;

            return text;
        }
    }
}