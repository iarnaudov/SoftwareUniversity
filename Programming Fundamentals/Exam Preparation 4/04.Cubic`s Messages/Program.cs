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
        while (true)
        {
            string pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";
            var messageRegex = new Regex(pattern);
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Over!") {  return; }
                var messageMatch = messageRegex.Match(line);
                if (!messageMatch.Success){continue;}
                var leftPart = messageMatch.Groups["leftPart"].Value;
                var message = messageMatch.Groups["message"].Value;
                var rightPart = messageMatch.Groups["rightPart"].Value;

                var messageLenght = int.Parse(Console.ReadLine());
                if (messageLenght != message.Length){ continue; }

                //var verificationCode = new string((leftPart + rightPart)
                //    .Where(char.IsDigit)
                //    .Select(a => int.Parse(a.ToString()))
                //    .Select(index => index >= 0 && index < message.Length ? message[index] : ' ' )
                //    .ToArray());

                var verificationCode = new StringBuilder();
                foreach (var @char in leftPart+rightPart)
                {
                    if (!char.IsDigit(@char))
                    {
                        continue;
                    }
                    var index = int.Parse(@char.ToString());
                    var isValidIndex = index >= 0 && index < message.Length;
                    if (isValidIndex)
                    {
                        verificationCode.Append(message[index]);
                    }
                    else
                    {
                        verificationCode.Append(' ');
                    }
                }

                Console.WriteLine($"{message} == {verificationCode}");
            }

           

        }
       




    }
}

