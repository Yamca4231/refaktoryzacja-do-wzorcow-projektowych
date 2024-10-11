using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OrkPrototype;


namespace OrkPrototype
{
    internal class Ork
    {
        public int Age { get; set; }
        public int Strenght { get; set; }
        public int Health { get; set; }

        public Ork copyOrk()
        {
            string orkCopy = JsonConvert.SerializeObject(this);
            Ork copiedOrk = JsonConvert.DeserializeObject<Ork>(orkCopy);
            copiedOrk.Strenght = new Random().Next(100);
            return copiedOrk;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Lista orków do walki
        List<Ork> battleOrks = new List<Ork>();

        // Tworzenie oryginalnego orka
        var ork = new Ork
        {
            Age = 30,
            Strenght = 50,
            Health = 100
        };

        // Dodanie oryginalnego orka do listy
        battleOrks.Add(ork);

        // Klonowanie orka
        Ork cloneOrk = ork.copyOrk();
        Ork cloneOrk2 = ork.copyOrk();

        // Dodanie klonów do listy
        battleOrks.Add(cloneOrk);
        battleOrks.Add(cloneOrk2);
        battleOrks.Add(ork.copyOrk()); // Dodanie kolejnego klona

        // Wyświetlenie szczegółów orków w konsoli
        foreach (var item in battleOrks)
        {
            Console.WriteLine($"Ork: , Wiek {item.Age}, " +
                $"Siła {item.Strenght}, Zycie {item.Health}, {item.GetType()}");
        }
    }
}