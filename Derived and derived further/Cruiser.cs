class Cruiser : Motorcycle
{

    public int SeatHeight;
    public Cruiser(string ma, string mo, int ye, int height) : base(ma, mo, ye)
    {
        this.SeatHeight = height;
    }

    public override string Ride()
    {
        return $"{base.Ride()} with a seat height of {this.SeatHeight} cm";
    }
}