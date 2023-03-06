class Program
{
    public static void Main(string[] args)
    {
        Calculator.StoreInMemory(2.0);
        Console.WriteLine(Calculator.RestoreFromMemory());
    }
}