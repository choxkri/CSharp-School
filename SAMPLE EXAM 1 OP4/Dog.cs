public class Dog : IAnimal, IComparable<IAnimal>, IEquatable<Dog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog(string n, int a)
    {
        this.Name = n;
        this.Age = a;
    }

    public int CompareTo(IAnimal obj)
    {
        return this.Age.CompareTo(obj.Age);
    }

    public bool Equals(Dog obj)
    {
        return (Name.Equals(obj.Name) && Age.Equals(obj.Age));
    }
}