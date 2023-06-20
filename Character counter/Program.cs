Console.Write("Input string: ");
string str = Console.ReadLine();
List<char> chars = new List<char>();
foreach (char character in str)
{
    chars.Add(character);
}
var list = str.Distinct();
foreach (var item in list)
{
    char current = item;
    var occurences = from character in chars
                     where character == current
                     select character;
    Console.WriteLine($"Char [{current}]: {occurences.Count()}");
}