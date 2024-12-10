using System;
using Factory;

namespace Builder
{
    internal class ArcherBuilder : WarriorBuilder
    {
        public ArcherBuilder(string name) : base(name) { }

        internal override void GoToArmy()
        {
            Warrior = new Archer(_name);
            Console.WriteLine($"{Warrior.Name} joined the army at level {Warrior.Level} with {Warrior.HealthPoints} health points.");
        }

        internal override void GetWeapon()
        {
            Console.WriteLine($"{Warrior.Name} receives a bow");
        }

        internal override IWarrior CombatTrain()
        {
            Console.WriteLine($"{Warrior.Name} is ready to fight");
            return new Archer(_name);
        }
    }
}
