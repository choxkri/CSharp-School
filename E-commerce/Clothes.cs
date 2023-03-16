class Clothes : Product
{
    public string Size;
    public string Material;

    public Clothes(string n, double p, int s, string size, string material) : base(n, p ,s)
    {
        this.Size = size;
        this.Material = material;
    }

    public override string ToString()
    {
        return base.ToString() + $"; size: {this.Size}; material: {this.Material}";
    }
}