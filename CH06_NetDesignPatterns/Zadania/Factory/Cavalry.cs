using System;

namespace Factory
{
    public class Cavalry : IWarrior
    {
        public string Name { get; set; }
        public string Weapon => "lance";
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public Cavalry(string name)
        {
            Name = name;
            HealthPoints = 120;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }
    }
}
