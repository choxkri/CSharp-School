using Newtonsoft.Json;

public static class HistoricalEventSearch
{
    public static List<HistoricalEvent> ReadEvents(string dataset)
    {
        StreamReader reader = new StreamReader(dataset);
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
    }

    public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> data, string search)
    {
        List<HistoricalEvent> historicalEvents = new List<HistoricalEvent>();
        var select = data.Where(x => x.Description.ToLower().Contains(search.ToLower()));
        foreach (var item in select)
        {
            historicalEvents.Add(item);
        }
        return historicalEvents;
    }

    public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> data, int yearbeg, int yearend)
    {
        List<HistoricalEvent> historicalEvents = new List<HistoricalEvent>();
        var select = data.Where(x => yearbeg <= x.Year && x.Year <= yearend);
        foreach (var item in select)
        {
            historicalEvents.Add(item);
        }
        return historicalEvents;
    }

    public static int AverageEventYear(List<HistoricalEvent> data)
    {
        int sum = 0;
        foreach (HistoricalEvent ev in data) 
        {
            sum += ev.Year;
        }
        return sum / data.Count;
    }
}