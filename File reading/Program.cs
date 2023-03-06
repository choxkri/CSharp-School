class Program
{
    public static void Main(string[] args)
    {
        string text = File.ReadAllText("MyTextFile.txt");
        Console.WriteLine(text);
    }
}