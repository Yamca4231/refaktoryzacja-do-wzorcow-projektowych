using System;

namespace Factory
{
    public class Archer : IWarrior
    {
        public string Name { get; set; }
        public string Weapon => "bow";
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public Archer(string name)
        {
            Name = name;
            HealthPoints = 80;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }
    }
}