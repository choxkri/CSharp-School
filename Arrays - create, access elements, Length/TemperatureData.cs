public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;

    public int NumberOfReadings
    {
        get
        {
            return _data.Length;
        }
    }

    public WeatherData(double[] data) => _data = data;

    public double GetHighestTemperature()
    {
        return _data.Max();
    }
}