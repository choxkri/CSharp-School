public class Bird : Creature, IFly, ISing
{
    private List<string> creatures = new() { "Worm", "Seed", "Insect" };
    public int Altitude { get; set; }
    private int _height;
    public override int Height
    {
        get
        {
            return _height;
        }

        protected set
        {
            if (value < 0)
            {
                _height = 0;
            }

            else if (value > 20)
            {
                _height = 20;
            }

            else
            {
                _height = value;
            }
        }
    }

    public Bird(int height, int weight) : base(height, weight) 
    {
        this.Height = height;
        this.Weight = weight;
    }

    public void Fly()
    {
        Altitude++;
    }

    public void Land()
    {
        Altitude = 0;
    }

    public string Sing()
    {
        return "Chirp chirp";
    }

    public override bool Eat(string animal)
    {
        if (creatures.Contains(animal))
        {
            Height += 3;
            Weight += 5;
            return true;
        }

        return false;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude: {Altitude}");
    }
}