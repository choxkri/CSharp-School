public class Item
{
    public readonly string Name;
    public double PricePerUnit;
    public int Quantity;


    public Item(string n, double p, int q)
    {
        this.Name = n;
        this.PricePerUnit = p;
        this.Quantity = q;
    }

    public double GetTotalPrice()
    {
        return PricePerUnit * Quantity;
    }

    public string GetInfo()
    {

        return $"{this.Name} x {this.Quantity} = {GetTotalPrice()}";
    }
}
