class Team
{
    public string Name;
    public List<Driver> Drivers;

    public Team(string name)
    {
        this.Name = name;
        this.Drivers = new List<Driver>();
    }

    public void ContractDriver(Driver driver)
    {
        this.Drivers.Add(driver);
    }
}