public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }


    public bool Equals(Person other)
    {
        if (other == null) return false;
        if (this.Name == other.Name &&  this.Age == other.Age) return true;
        return false;
    }

    public override string ToString()
    {
        return $"{this.Name} ({this.Age})";
    }
}