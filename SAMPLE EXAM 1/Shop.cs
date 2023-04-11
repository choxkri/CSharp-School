public static class Shop
{
    public static List<Item> Inventory = new() { };
    public const int MaxQuantity = 5;

    public static void AddItemToInventory(Item item)
    {
        if (item != null)
        {
            if (item.Quantity <= MaxQuantity)
            {
                foreach (Item i in Inventory)
                {
                    if (i.Name == item.Name && i.Quantity == item.Quantity)
                    {
                        return;
                    }
                }

                Inventory.Add(item);
            }
        }
    }

    public static Item BuyItem(string n, int q, double p)
    {
        foreach (Item item in Inventory)
        {
            if (item.Name == n && item.Quantity == q && item.GetTotalPrice() == p)
            {
                return item;
            }
        }

        return null;
    }
}