public class Square : Shape
{
    public double Length { get; set; }
    public Square(double l)
    {
        this.Length = l;
    }

    public override double Area
    {
        get { return Math.Pow(Length, 2); }
    }

    public override double Perimeter
    {
        get { return 4 * Length; }
    }

    public override string Info()
    {
        return $"Circle with sides of {this.Length}";
    }

}