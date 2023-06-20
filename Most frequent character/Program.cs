string input = Console.ReadLine();

var query = input.GroupBy(x => x).OrderByDescending(x => x.Count()).ToList();

foreach (var item in query)
{
    Console.WriteLine(item.Key);
    Environment.Exit(0);
}

