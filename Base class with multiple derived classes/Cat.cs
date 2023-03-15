class Cat : Animal
{
    public Cat(string n) : base(n) 
    {
        this.Sound = "Meow!";
    }

    public void Climb()
    {
        Console.WriteLine($"{this.Name} climbs the curtains");
    }
}