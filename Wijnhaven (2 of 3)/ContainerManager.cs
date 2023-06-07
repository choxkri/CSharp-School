using Newtonsoft.Json;

public static class ContainerManager
{
    public static Queue<Container> selectedForInspection = new Queue<Container>();
    public static void Start(string path)
    {
        IEnumerable<string> allfiles = Directory.EnumerateFiles(path);
        foreach (string file in allfiles)
        {
            List<Container> list = ProcessManifest(file);
            MarkForInspection(list, x => x.Categories.Contains("Fruits") && x.Origin == "COL");
        }
    }

    public static List<Container> ProcessManifest(string path)
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, path);
        string JSONString = File.ReadAllText(filePath);

        List<Container> list = JsonConvert.DeserializeObject<List<Container>>(JSONString) ?? new List<Container>();
        return list;
    }

    public static List<Container> SearchByOrigin(List<Container> list, string origin)
    {
        List<Container> filtered = list.FindAll(x => x.Origin == origin);
        return filtered;
    }

    public static Container SearchForHeaviest(List<Container> list)
    {
        Container result = list.MaxBy(x => x.Weight);
        return result;
    }

    public static void MarkForInspection(List<Container> list)
    {
        foreach (Container cont in list)
        {
            cont.Status = 9;
            ContainerLogger.Log(cont);
        }
        Console.WriteLine($"Number of containers selected for inspection: {list.Count}");
    }

    public static void MarkForInspection(List<Container> list, Func<Container, bool> filter)
    {
        int count = 0;
        foreach (Container cont in list)
        {
            if (filter(cont))
            {
                cont.Status = 1;
                selectedForInspection.Enqueue(cont);
                ContainerLogger.Log(cont);
                count++;
            }

            else
            {
                cont.Status = 9;
                ContainerLogger.Log(cont);
            }
        }
        Console.WriteLine($"Number of containers selected for inspection: {count}");
    }
}