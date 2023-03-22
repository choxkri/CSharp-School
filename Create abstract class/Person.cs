public abstract class Person
{
    public int Age { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName{ get; set; }

    protected Person(string fn, string ln, int age)
    {
        this.Age = age;
        this.FirstName = fn;
        this.LastName = ln;
    }

    public abstract string Greet();

    public virtual string GetFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }
}