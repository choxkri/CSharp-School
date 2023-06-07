
string[] persons = new string[] { "Dave", "John", "Peter", "Johanna", "Bart", "Henk", "Marie" };
string[] students = new string[] { "Dave", "Micheal", "Roxanne", "Johanna", "John", "Bart", "Henk" };

Console.WriteLine("These names are in both datasets:");
List<string> both = persons.Intersect(students).ToList();
List<string> both2 = students.Intersect(persons).ToList();
List<string> complete2 = both.Union(both2).ToList();
foreach (string s in complete2)
{
    Console.WriteLine(s);
}

Console.WriteLine();


Console.WriteLine("These names are unique:");
persons.Concat(students).Distinct().OrderBy(x => x).ToList().ForEach(Console.WriteLine);