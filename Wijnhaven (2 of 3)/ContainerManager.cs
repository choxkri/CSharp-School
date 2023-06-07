using Newtonsoft.Json;

public static class ContainerManager
{
    public static void Start(string path)
    {
        IEnumerable<string> allfiles = Directory.EnumerateFiles(path);
        foreach (string file in allfiles)
        {
            foreach (Container cont in ProcessManifest(file))
            {
                Console.WriteLine(cont.ToString());
            }
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
}