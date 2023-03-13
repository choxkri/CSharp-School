class Point
{
    public double x;
    public double y;

    public Point()
    {

    }
    public Point(double num1, double num2)
    {
        this.x = num1;
        this.y = num2;
    }

    public Point(Point p) : this(p.x, p.y)
    {

    }

    public static double EuclideanDistance(Point p1, Point p2)
    {
        double result = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        return result;
    }
}