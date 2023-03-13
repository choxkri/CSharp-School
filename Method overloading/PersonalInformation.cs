static class PersonalInformation
{

    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }

    public static void PrintName(string fn, string ln)
    {
        Console.WriteLine($"{fn} {ln}");
    }

    public static void PrintName(char n, string ln)
    {
        Console.WriteLine($"{n}. {ln}");
    }
}