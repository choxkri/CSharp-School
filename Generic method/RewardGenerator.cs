public static class RewardGenerator
{
    public static Random rng = new Random(0);

    public static T GetRandomElement<T>(List<T> list)
    {

        return list[rng.Next(list.Count-1)];
        
    }
}