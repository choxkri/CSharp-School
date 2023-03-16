class Computer : Electronics
{
    public Computer(string n, double p, int s, string br, string mo) : base(n, p , s, br, mo)
    {

    }

    public override void Sell(int units)
    {
        base.Sell(units);
        this.Stock = 5;
    }


}
