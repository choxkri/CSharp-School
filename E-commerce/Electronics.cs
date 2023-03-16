class Electronics : Product
{
    string Brand;
    string Model;

    public Electronics(string n, double p, int s, string br, string mo) : base(n, p, s)
    {
        Brand = br;
        Model = mo;
    }

    public override void Sell(int units)
    {
        base.Sell(units);
        this.Stock = 10;
    }

    public override string ToString()
    {
        return $"Name: {this.Name} ({this.Brand} {this.Model}); price: {this.Price}; stock: {this.Stock}";
    }
}