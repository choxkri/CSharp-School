public class CurrentConditionsDisplay : IDisplay, IObserver
{
    private WeatherData _observable;
    private double _temperature;
    private double _humidity;

    public CurrentConditionsDisplay(WeatherData observable)
    {
        this._observable = observable;
    }

    public void Update()
    {
        _temperature = _observable.Temperature;
        _humidity = _observable.Humidity;
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: [{_temperature}]C degrees and {_humidity}% humidity");
    }
}