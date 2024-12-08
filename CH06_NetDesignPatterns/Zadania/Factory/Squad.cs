namespace Factory
{
    internal class Squad
    {
        public Warrior CreateSoldier(string type, string name)
        {
            switch (type)
            {
                case "infantry":
                    return new Infantry(name);
                case "archer":
                    return new Archer(name);
                case "cavalry":
                    return new Cavalry(name);
                default:
                    return new Infantry(name);
            }
        }
    }
}