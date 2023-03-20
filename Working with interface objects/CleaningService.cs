public static class CleaningService
{
    public static void Clean(ICleanable obj)
    {
        obj.Clean();
    }

    public static void Clean(List<ICleanable> list)
    {
        foreach (ICleanable obj in list) 
        {
            obj.Clean();
        }
    }
}