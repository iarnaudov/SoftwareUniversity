using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        
        int initialHealth = int.Parse(Console.ReadLine());
        string virusName = Console.ReadLine();
        var maxIntialHealth = initialHealth;
        var timeToDefeat = 0;
        var virusNamesList = new List<string>();

        while (virusName != "end")
        {
            //virus strenght
            var virusStrenght = virusName.Sum(x => x) / 3;
            //defeat time
            var defeatVirusTime = virusStrenght * virusName.Length;
            var defeatVirusMinutes = defeatVirusTime / 60;
            var defeatVirusSeconds = defeatVirusTime % 60;

            if (!virusNamesList.Contains(virusName))
            {
                virusNamesList.Add(virusName);
                timeToDefeat = virusStrenght * virusName.Length;
            }

            else
            {
                timeToDefeat = (virusStrenght * virusName.Length) / 3;
            }
            Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeToDefeat} seconds");
            if (initialHealth - timeToDefeat > 0)
            {
                initialHealth -= timeToDefeat;
                var minutesToDefeat = timeToDefeat / 60;
                var secondsToDefeat = timeToDefeat % 60;

                Console.WriteLine($"{virusName} defeated in {minutesToDefeat}m {secondsToDefeat}s.");
                Console.WriteLine($"Remaining health: {initialHealth}");

                if (initialHealth + (int)(initialHealth * 0.2) > maxIntialHealth)
                {
                    initialHealth = maxIntialHealth;
                }

                else
                {
                    initialHealth += (int)(initialHealth * 0.2);
                }
            }

            else
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }

            virusName = Console.ReadLine();
        }

        Console.WriteLine($"Final Health: {initialHealth}");

        





    }
}

