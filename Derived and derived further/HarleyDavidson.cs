class HarleyDavidson : Cruiser
{
    public HarleyDavidson(string mo, int ye) : base("Harley Davidson", mo, ye, 68)
    {

    }

    public override string Ride()
    {
        return $"{base.Ride()} and with pride.";
    }
}