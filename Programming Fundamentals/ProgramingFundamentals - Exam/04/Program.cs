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
        var pokeNameEvoIndex =
              new Dictionary<string, List<EvolutionList>>();

        while (true)
        {
            var input = Console.ReadLine().Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input[0] == "wubbalubbadubdub"){break;}
            if (input.Length == 1)
            {
                var pokeName = input[0];
                if (pokeNameEvoIndex.ContainsKey(pokeName))
                {
                    Console.WriteLine($"# {pokeName}");
                    foreach (var item in pokeNameEvoIndex[pokeName])
                    {
                        Console.WriteLine($"{item.Evolution} <-> {item.Index}");
                    }
                }
                continue;
            }
            else
            {
                var pokeName = input[0];
                var evolution = input[1];
                var index = int.Parse(input[2]);

                if (!pokeNameEvoIndex.ContainsKey(pokeName))
                {
                    pokeNameEvoIndex[pokeName] = new List<EvolutionList>();
                }
                if (pokeNameEvoIndex.ContainsKey(pokeName))
                {
                    var data = new EvolutionList
                    {
                        Evolution = evolution,
                        Index = index,
                    };

                    pokeNameEvoIndex[pokeName].Add(data);
                }
            }
        }


        foreach (var pokemon in pokeNameEvoIndex)
        {
            var pokeValue = pokemon.Value.OrderByDescending(a => a.Index).ToArray();
            Console.WriteLine($"# {pokemon.Key}");
            foreach (var item in pokeValue)
            {
                Console.WriteLine($"{item.Evolution} <-> {item.Index}");
            }
        }


    }
}


class EvolutionList
{
    public string Evolution { get; set; }
    public int Index { get; set; }
}