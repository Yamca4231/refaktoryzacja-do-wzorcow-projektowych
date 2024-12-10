using System;
using Factory;

namespace Builder
{
    internal class CavalryBuilder : WarriorBuilder
    {
        public CavalryBuilder(string name) : base(name) { }

        internal override void GoToArmy()
        {
            Warrior = new Cavalry(_name);
            Console.WriteLine($"{Warrior.Name} joined the army at level {Warrior.Level} with {Warrior.HealthPoints} health points.");
        }

        internal override void GetWeapon()
        {
            Console.WriteLine($"{Warrior.Name} receives a bow");
        }

        internal override IWarrior CombatTrain()
        {
            Console.WriteLine($"{Warrior.Name} is ready to fight");
            return new Cavalry(_name);
        }
    }
}