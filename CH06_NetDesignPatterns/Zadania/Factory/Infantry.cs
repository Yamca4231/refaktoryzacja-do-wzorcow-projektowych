using System;

namespace Factory
{
    public class Infantry : Warrior
    {
        public string Name { get; set; }
        public override string Weapon => "sword";
        public override int HealthPoints => 100;

        public Infantry(string name)
        {
            Name = name;
            Level = new Random().Next(1, 11); // Generuje poziom od 1 do 10
        }

    }
}