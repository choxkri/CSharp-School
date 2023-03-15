class Cuboid : Rectangle
{
    public int Height;
    public Cuboid(int length, int width, int height) : base(length, width)
    {
        this.Height = height;
    }

    public int Volume()
    {
        return this.Height * this.Width * this.Length;
    }

    public override int Area()
    {
        return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
    }

    public override int Perimeter()
    {
        return 4 * (this.Length + this.Width + this.Height);
    }

    public override string Info()
    {
        return base.Info() + $"; Height: {this.Height}";
    }

}