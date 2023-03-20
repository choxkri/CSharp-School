public class Pedestrian : Person, ICommute
{
    public Pedestrian(string name) : base(name) { }

    public void Move(int dist)
    {
        Console.WriteLine($"Walked {dist} kms");
    }
}