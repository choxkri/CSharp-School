class Dog : Animal
{
    public Dog(string n) : base(n)
    {
        this.Sound = "Woof!";
    }

    public void Fetch()
    {
        Console.WriteLine($"{this.Name} fetches the stick");
    }
}