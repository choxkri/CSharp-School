class Program
{
    public static void Main(string[] args)
    {
        Person john = new("John Doe");
        Employee jane = new("Jane Doe", 3000.0);
        Console.WriteLine(john.Name);
        Console.WriteLine(jane.Name);
        Console.WriteLine(jane.Salary);
    }
}