class ShoppingCart
{
    List<GroupedShopItem> Groceries;

    public ShoppingCart()
    {
        this.Groceries = new List<GroupedShopItem>();
    }

    public void AddItem(ShopItem item)
    {
        foreach (GroupedShopItem grocery in this.Groceries)
        {
            if (item.ID == grocery.Item.ID)
            {
                grocery.Quantity++;
                return;
            }
        }
        GroupedShopItem converted = new GroupedShopItem(item);
        this.Groceries.Add(converted);
    }

    public void AddItem(ShopItem item, int amount)
    {
        foreach (GroupedShopItem grocery in this.Groceries)
        {
            if (item.ID == grocery.Item.ID)
            {
                grocery.Quantity += amount;
                return;
            }
        }
        GroupedShopItem converted = new GroupedShopItem(item);
        converted.Quantity = amount;
        this.Groceries.Add(converted);
    }

    public GroupedShopItem FindItem(ShopItem item)
    {
        foreach (GroupedShopItem grocery in this.Groceries)
        {
            if (item.ID == grocery.Item.ID)
            {
                return grocery;
            }
        }

        return null;
    }

    public string Contents()
    {
        string contents = "";
        foreach (GroupedShopItem grocery in this.Groceries)
        {
            contents = contents + $"{grocery.Item.Name} x {grocery.Quantity}\n";
        }

        return contents;

    }

    public double TotalPrice()
    {
        double price = 0;

        foreach (GroupedShopItem grocery in this.Groceries)
        {
            price += grocery.Item.Price * grocery.Quantity;
        }

        return price;
    }
}