public class Inventory
{
    private Dictionary<string, Product> _products = new Dictionary<string, Product>();

    public void AddProduct(string productName, double price, int quantity)
    {
        Product i = new(productName, price, quantity);
        _products.Add(productName, i);
    }

    public void AddProduct(string productName, double price) 
    {
        Product i = new(productName, price, 0);
        _products.Add(productName, i);
    }

    public void RemoveProduct(string productName) 
    {
        _products.Remove(productName);
    }

    public Product GetProduct(string productName)
    {
        return _products[productName];
    }

    public string GetInventorySummary()
    {
        int quant = 0;
        double tprice = 0.0;

        foreach (KeyValuePair<string, Product> kvp in _products)
        {
            quant += kvp.Value.Quantity;
            tprice += kvp.Value.Quantity * kvp.Value.Price;
        }

        return $"Total products: {quant}\nTotal value: ${tprice}";
    }
}