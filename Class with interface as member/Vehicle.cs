public class Vehicle
{
    public string Make;
    public string Model;
    public IEngine Engine;

    public Vehicle(string Make, string Model, IEngine engine)
    {
        this.Make = Make;
        this.Model = Model;
        this.Engine = engine;
    }
}