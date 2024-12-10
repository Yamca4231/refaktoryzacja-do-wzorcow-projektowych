namespace Factory
{
    public interface IWarrior
    {
        public string Name { get; set; }
        
        public string Weapon { get; }
        public int HealthPoints { get; set; }
        public int Level { get; set; } // Losowy poziom od 1 do 10
    }
}

