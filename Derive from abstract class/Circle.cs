public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double r)
    {
        this.Radius = r;
    }

    public override double Area
    {
        get { return Math.PI * Math.Pow(Radius, 2); }
    }

    public override double Perimeter
    {
        get { return 2 * (Radius * Math.PI); }
    }

    public override string Info()
    {
        return $"Circle with a radius of {this.Radius}";
    }

}