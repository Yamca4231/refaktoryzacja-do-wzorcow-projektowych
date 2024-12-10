using Factory;

namespace Builder
{
    internal abstract class WarriorBuilder
    {
        protected readonly string _name;
        public WarriorBuilder(string name)
        {
            _name = name;
        }
        public IWarrior Warrior { get; set; }
        internal abstract void GoToArmy();
        internal abstract void GetWeapon();
        internal abstract IWarrior CombatTrain();
    }
}
