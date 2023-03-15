class GroupedShopItem
{
    public ShopItem Item;
    public int Quantity;

    public GroupedShopItem(ShopItem item)
    {
        this.Item = item;
        this.Quantity = 1;
    }
}