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

    public void Sort(bool order)
    {
        if (order)
        {
            Array.Sort(_data);
        }

        else
        {
            Array.Sort(_data);
            Array.Reverse(_data);
        }
    }

    public void PrintTemperatures()
    {
        foreach (double temp in _data)
        {
            Console.WriteLine(temp);
        }
    }
}