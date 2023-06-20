public class Cat : IAnimal, IComparable<IAnimal>, IEquatable<Cat>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Cat(string n, int a)
    {
        this.Name = n;
        this.Age = a;
    }

    public int CompareTo(IAnimal obj)
    {
        return this.Age.CompareTo(obj.Age);
    }

    public bool Equals(Cat obj)
    {
        return (Name.Equals(obj.Name) && Age.Equals(obj.Age));
    }
}