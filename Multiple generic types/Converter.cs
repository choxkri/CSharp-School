public static class Converter
{
    public static T2 ConvertVariables<T1, T2>(T1 x)
    {
        return (T2)Convert.ChangeType(x, typeof(T2));
    }
}