using System;

namespace Factory
{
    public class Archer : Warrior
    {
        public string Name { get; set; }
        public override string Weapon => "bow";
        public override int HealthPoints => 80;

        public Archer(string name)
        {
            Name = name;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }
    }
}