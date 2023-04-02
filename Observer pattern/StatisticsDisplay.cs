public class StatisticsDisplay : IObserver, IDisplay
{
    private WeatherData _observable;
    private double _minTemperature;
    private double _maxTemperature;
    private double _avgTemp;
    private List<double> _allTemps = new List<double>();


    public StatisticsDisplay(WeatherData observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        if (_allTemps.Count < 0) 
        {
            _minTemperature = _observable.Temperature;
            _maxTemperature = _observable.Temperature;
            _avgTemp = _observable.Temperature;
            _allTemps.Add(_observable.Temperature);
        }

        _allTemps.Add(_observable.Temperature);

        double sum = 0;
        foreach (double temp in _allTemps) 
        {
            sum += temp;
        }
        _avgTemp = sum / _allTemps.Count;

        if (_observable.Temperature < _minTemperature) 
        {
            _minTemperature = _observable.Temperature;
        }

        if (_observable.Temperature > _maxTemperature) 
        {
            _maxTemperature = _observable.Temperature;
        }

    }

    public void Display()
    {
        Console.WriteLine($"Avg/Min/Max temperature = {_avgTemp}/{_minTemperature}/{_maxTemperature}");
    }
}