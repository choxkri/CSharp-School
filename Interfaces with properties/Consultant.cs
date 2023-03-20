public class Consultant : IPayable
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }

    public string Info
    {
        get
        {
            return $"{Name}; {HourlyRate}/hour";
        }
    }

    public double GetPaymentAmount()
    {
        return HourlyRate * HoursWorked;
    }
}