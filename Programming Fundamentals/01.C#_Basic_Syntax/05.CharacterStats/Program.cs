using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int CurrentHealth = int.Parse(Console.ReadLine());
        int MaxHealth = int.Parse(Console.ReadLine());
        int CurrentEnergy = int.Parse(Console.ReadLine());
        int MaxEnergy = int.Parse(Console.ReadLine());
        if ((CurrentHealth <= MaxHealth) && (CurrentEnergy<=MaxEnergy)) {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', CurrentHealth), new string('.', MaxHealth - CurrentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', CurrentEnergy), new string('.', MaxEnergy - CurrentEnergy));
        }
        else
        {
            Console.WriteLine("Invalid num");
        }
  

    }
}

