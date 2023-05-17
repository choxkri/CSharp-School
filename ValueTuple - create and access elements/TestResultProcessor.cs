public static class TestResultProcessor
{
    public static (double, bool) GetTestResult(int p, int maxp)
    {
        double grade = (double)p / maxp;
        grade = grade * 10.0;
        bool passed = false;
        if (grade >= 5.5)
        {
            passed = true;
        }
        var result = (grade, passed);
        return result;
    }

    public static void PrintTestResult((double, bool) result)
    {
        if (result.Item2 == true)
        {
            Console.WriteLine($"Grade: {result.Item1}");
            Console.WriteLine("Passed");
        }

        else
        {
            Console.WriteLine($"Grade: {result.Item1}");
            Console.WriteLine("Did not pass");
        }
    }
}