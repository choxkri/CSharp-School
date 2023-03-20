class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;

    public void Move(int dist)
    {
        Mileage += dist;
        Console.WriteLine($"Drove {dist} kms");
        Console.WriteLine($"Mileage: {Mileage} kms");
    }
}