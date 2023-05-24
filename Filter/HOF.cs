using System.Linq;

public static class HOF
{
    // Filter goes here

    public static List<T> Filter<T>(List<T> list, Func<T, bool> lam)
    {
        return list.Where(lam).ToList();
    }


}