public static class ContainerLogger
{
    public static Dictionary<string, Container> containerLog = new Dictionary<string, Container>();

    public static void Log(Container container)
    {
        if (!containerLog.ContainsKey(container.Code))
        {
            containerLog.Add(container.Code, container);
            return;
        }

        containerLog[container.Code] = container;
    }

    public static void Print()
    {
        foreach (KeyValuePair<string, Container> kvp in containerLog)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}