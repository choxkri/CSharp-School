public static class ColorChecker
{
    public static void ColorExists(string color, List<string> colors)
    {
        bool result = HasMatch(colors, x => x == color);
        Console.WriteLine($"Color '{color}' exists: {result}");
    }
    public static void ColorStartingWith(string letter, List<string> colors)
    {
        bool result = HasMatch(colors, x => x.StartsWith(letter));
        Console.WriteLine($"Color that starts with letter '{letter}' exists: {result}");
    }

    public static bool HasMatch(List<string> colors, Func<string, bool> check)
    {
        if (colors.Count == 0) { return false; }


        bool result = (check(colors[colors.Count-1]));
        if (result ) { return true; }
        colors.RemoveAt(colors.Count-1);
        return HasMatch(colors, check);

    }
}
