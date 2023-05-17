public class Program
{
    public static void Main(string[] args)
    {
        var test = TestResultProcessor.GetTestResult(1, 2);
        TestResultProcessor.PrintTestResult(test);
    }
}