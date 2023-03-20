public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    public void Resize(double scale)
    {
        Size = (int)(scale * Size);
    }

    public void Draw()
    {
        for (int x = 0; x < Size; x++)
        {
            string line = new string('*', Size);
            Console.WriteLine(line);
        }
        Console.WriteLine();
    }
}
