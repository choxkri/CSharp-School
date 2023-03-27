class Program
{
    public static void Main(string[] args)
    {
        Employee john = new("John", "Doe", "john.doe@example.com");
        Manager jane = new("Jane", "Doe", "jane.doe@example.com", "Sales");
        SalesPerson bob = new("Bob", "Smith", "bob.smith@example.com", 100000);
        List<Employee> list = new List<Employee>()
        {
            john,
            jane,
            bob
        };

        foreach(Employee e in list) 
        {
            e.PrintEmployeeInfo();
        }

        foreach(Employee e in list)
        {
            if (e is Manager x) 
            {
                x.PrintEmployeeInfo();
                continue;
            }

            if (e is SalesPerson y)
            {
                y.PrintEmployeeInfo();
                continue;
            }

            e.PrintEmployeeInfo();
        }
    }
}