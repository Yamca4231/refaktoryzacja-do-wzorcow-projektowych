using Factory;

namespace Builder
{
    internal class WarriorBase
    {
        public IWarrior warrior;
        public WarriorBase(Builder.WarriorBuilder warriorBuilder)
        {
            warriorBuilder.GoToArmy();
            warriorBuilder.GetWeapon();
            warrior = warriorBuilder.CombatTrain();
        }
    }
}
