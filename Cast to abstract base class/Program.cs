class Program
{
    public static void Main(string[] args)
    {
        List<Bill> list = new List<Bill>
        {
            new ElectricityBill(50, "John Doe"),
            new ElectricityBill(75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(125, "John Doe", true)
        };
        double total = 0;
        foreach (Bill bill in list) 
        {
            Console.WriteLine(bill.GetDescription());
            total += bill.Amount;
        }
        Console.WriteLine($"Total amount: {(int)total}");
    }
}