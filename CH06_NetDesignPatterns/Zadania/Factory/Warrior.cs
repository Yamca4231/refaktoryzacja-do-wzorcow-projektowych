namespace Factory
{
    public abstract class Warrior
    {
        public string Name { get; set; }
        public abstract string Weapon { get; }
        public abstract int HealthPoints { get; }
        public int Level { get; set; } // Losowy poziom od 1 do 10

        
    }
}
