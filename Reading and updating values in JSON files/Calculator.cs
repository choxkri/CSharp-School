using Newtonsoft.Json;
static class Calculator
{
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        return x / y;
    }

    public static double Modulo(double x, double y)
    {
        return x % y;
    }

    public static void StoreInMemory(double x)
    {
        StreamWriter writer = new StreamWriter("Memory.json"); //fileName is "Memory.json"
        writer.Write(JsonConvert.SerializeObject(x));
        writer.Close();
        writer.Dispose();
    }

    public static double RestoreFromMemory()
    {
        StreamReader reader = new StreamReader("Memory.json"); //fileName is "Memory.json"
        string jsonString = reader.ReadToEnd();
        reader.Close();
        reader.Dispose();
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;
        return fromjson;
    }
}