public abstract class Creature
{
    private int _height;
    public virtual int Height
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

            else
            {
                _height = value;
            }
        }
    }

    public int Weight
    {
        get
        {
            return Weight;
        }

        protected set
        {
            if (value < 0)
            {
                Weight = 0;
            }

            else
            {
                Weight = value;
            }
        }
    }

    public Creature(int h, int w)
    {
        this.Weight = w;
        this.Height = h;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Height: {this.Height}");
        Console.WriteLine($"Weight: {this.Weight}");
    }

    public abstract bool Eat(string s);
}