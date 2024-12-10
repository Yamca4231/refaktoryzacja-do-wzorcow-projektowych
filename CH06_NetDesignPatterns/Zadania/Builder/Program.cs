using System;
using System.Collections.Generic;
using Factory;
using Builder;

class Program
{
    static void Main(string[] args)
    {
        // Lista przechowująca wojowników
        List<IWarrior> newArmy = new();

        // Definicja liczby wojowników dla każdego typu
        var warriorTypes = new Dictionary<string, int>
        {
            { "Infantry", 2 }, // 2 piechurów
            { "Cavalry", 2 },  // 2 konnych
            { "Archer", 2 }    // 2 strzelców
        };

        // Tworzenie wojowników w pętli
        foreach (var (type, count) in warriorTypes)
        {
            for (int i = 1; i <= count; i++)
            {
                string name = $"{type}{i}"; // Generowanie nazw, np. Infantry1, Infantry2
                WarriorBuilder builder = type switch
                {
                    "Infantry" => new InfantryBuilder(name),
                    "Cavalry" => new CavalryBuilder(name),
                    "Archer" => new ArcherBuilder(name),
                    _ => throw new ArgumentException($"Unknown warrior type: {type}")
                };

                var post = new WarriorBase(builder);
                newArmy.Add(post.warrior);
            }
        }

        // Wyświetlenie wszystkich wojowników w nowym garnizonie
        Console.WriteLine("\n--- New Army Composition ---");
        foreach (var item in newArmy)
        {
            Console.WriteLine($"Nazywam się {item.Name} i jestem {item.GetType().Name}");
        }
    }
}
