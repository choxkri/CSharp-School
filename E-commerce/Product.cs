class Product
{
    public string Name;
    public double Price;
    public int Stock;

    public Product(string name, double price, int stock)
    {
        this.Name = name;
        this.Price = price;
        this.Stock = stock;
    }

    public virtual void Sell(int units)
    {
        if (this.Stock >= units) 
        {
            this.Stock -= units;
            Console.WriteLine($"{units} units of {this.Name} have been sold.");
        }

        else 
        {
            Console.WriteLine($"{this.Name} is out of stock.");
        }
    }

    public override string ToString()
    {
        return $"Name: {this.Name}; price: {this.Price}; stock: {this.Stock}";
    }
}