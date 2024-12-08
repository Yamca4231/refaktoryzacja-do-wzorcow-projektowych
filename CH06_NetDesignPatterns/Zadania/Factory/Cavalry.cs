using System;

namespace Factory
{
    public class Cavalry : Warrior
    {
        public string Name { get; set; }
        public override string Weapon => "lance";
        public override int HealthPoints => 120;

        public Cavalry(string name)
        {
            Name = name;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }
    }
}
