using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmaiStatistic
/*
 You will receive n emails from the console. Some of these emails will be invalid. In order one email to be valid it should pass the following conditions:
•	The username of the user should be at least 5 characters long and consist only of uppercase and lowercase Latin letters.
•	The username should be followed immediately by ‘@’.
•	The domain part should consist of two parts:
o	The mail server, which should contain only lowercase Latin letters and should be at least 3 letters long.
o	The top-level domain, which can be one of the following: .com, .bg or .org

 */
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}[.](bg|org|com))$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> emailCollection = new Dictionary<string, List<string>>();

            for (int index = 0; index < n; index++)
            {
                string currentEmail = Console.ReadLine();

                if (regex.IsMatch(currentEmail))
                {
                    Match match = regex.Match(currentEmail);

                    string userMatch = match.Groups["username"].Value;
                    string domainMatch = match.Groups["domain"].Value;

                    if (!emailCollection.ContainsKey(domainMatch))
                    {
                        emailCollection[domainMatch] = new List<string>();
                    }

                    if (!emailCollection[domainMatch].Contains(userMatch))
                    {
                        emailCollection[domainMatch].Add(userMatch);

                    }
                }
            }
            foreach (var kvp in emailCollection.OrderByDescending(x => x.Value.Count))
            {
                var domain = kvp.Key;
                Console.WriteLine($"{domain}: ");

                List<string> usernames = kvp.Value.ToList();
                foreach (string user in usernames)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}