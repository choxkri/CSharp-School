class Player
{
    public string Name;
    public int MaxHP;
    public int Strength;
    public int CurrentHP;
    public int Experience;
    public bool IsAlive;
    public int Level;

    public Player(string name, int baseHP, int baseStrength)
    {
        this.Name = name;
        this.MaxHP = baseHP + 10;
        this.CurrentHP = baseHP + 10;
        this.Strength = baseStrength + 3;
        this.Experience = 0;
        this.IsAlive = true;
        this.Level = 1;
    }

    public int GetLevel()
    {
        return this.Level;
    }


    public void Attack(Monster monster)
    {
        monster.HP -= this.Strength;
        if (monster.HP <= 0)
        {
            monster.HP = 0;
            monster.IsAlive = false;
        }

        if (!monster.IsAlive)
        {
            this.Experience += monster.Experience;
            for (int i = this.Level; i < World.ExperienceChart.Count + 1; i++)
            {
                if (World.ExperienceChart[i - 1] < this.Experience)
                {
                    this.Level++;
                    this.MaxHP += 10;
                    this.Strength += 3;
                }
            }
            return;
        }

    }

    public void TakeDamage(int dmg)
    {
        this.CurrentHP -= (int)(dmg - (this.Strength / 4));
    }

}