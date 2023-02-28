using System.Threading;

class Monster
{
    public string Name;
    public int HP;
    public int Strength;
    public int Experience;
    public bool IsAlive;

    public Monster(string name, int hP, int strength, int experience)
    {
        this.Name = name;
        this.HP = hP;
        this.Strength = strength;
        this.Experience = experience;
        this.IsAlive = true;
    }

    public void Attack(Player player)
    {
        player.CurrentHP -= this.Strength;
        if (player.CurrentHP <= 0)
        {
            player.CurrentHP = 0;
            player.IsAlive = false;
        }
    }
}