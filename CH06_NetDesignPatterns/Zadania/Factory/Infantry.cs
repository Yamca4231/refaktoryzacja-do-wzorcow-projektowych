using System;

namespace Factory
{
    public class Infantry : IWarrior
    {
        public string Name { get; set; }
        public string Weapon => "sword";
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public Infantry(string name)
        {
            Name = name;
            HealthPoints = 100;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }

    }
}