public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }


    public bool Equals(Person other)
    {
        if (other == null) return false;
        if (this.Name == other.Name && this.Age == other.Age)
        {
            return true;
        }
        if (this.Name != other.Name || this.Age != other.Age) return false;
        else return true;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Person) return false;
        return base.Equals(obj as Person);
    }

    public override string ToString()
    {
        return $"{this.Name} ({this.Age})";
    }
}