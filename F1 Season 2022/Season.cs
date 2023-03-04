class Season
{
    public int Year;
    public List<Race> Races;
    public List<Team> Teams;
    public List<Driver> Drivers;
    Dictionary<string, List<int>> Scores;

    public Season(int year, List<Race> races, List<Team> teams)
    {
        this.Year = year;
        this.Races = races;
        this.Teams = teams;
        this.Drivers = new List<Driver>();
        this.Scores = new Dictionary<string, List<int>>();
    }

    public void RunSeason()
    {
        foreach (Team team in this.Teams)
        {
            foreach(Driver driver in team.Drivers)
            {
                Scores[driver.Name] = new List<int>();
                this.Drivers.Add(driver);
            }
        }

        foreach (Race race in this.Races)
        {
            Shuffle(this.Drivers);
            Console.WriteLine($"{this.Drivers[0].Name} of {}");
        }
    }

    public void SeasonResults()
    {

    }



    static void Shuffle<T>(List<T> list)
    {
        Random random = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}