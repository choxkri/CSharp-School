public class TextFile : File, IPrintable
{
    public string Name;
    public string Contents;

    public TextFile(string name, string contents) : base(name)
    {
        name = $"{name}.txt";
        this.Name = name;
        this.Contents = contents;
    }

    public void Print()
    {
        Console.WriteLine(this.Contents);
    }
}