public class WeatherData : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();
    public double Temperature;
    public double Humidity;
    public double Pressure;

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer) 
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
    }

    public void Update()
    {
        NotifyObservers();
    }

    public void SetMeasurements(double temp, double humidity, double pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }
}