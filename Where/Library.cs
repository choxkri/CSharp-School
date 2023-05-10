public static class Library
{
    public static List<Book> Books = new();
    public static List<Customer> Customers = new();

    public static T FindByID<T>(List<T> list, int id) where T : IHasID
    {
        foreach (T customer in list)
        {
            if (customer.ID == id)
            {
                return customer;
            }
        }

        return default;
    }


}