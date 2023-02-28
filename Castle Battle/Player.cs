class Player
{
    public string Name;
    public int MaxHP;
    public int Strength;
    public int CurrentHP;
    public int Experience;

    public Player(string name, int baseHP, int baseStrength)
    {
        this.Name = name;
        this.MaxHP = baseHP;
        this.CurrentHP = baseHP;
        this.Strength = baseStrength;
        this.Experience = 0;
    }
}