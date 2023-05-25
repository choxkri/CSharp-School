public class Container
{
    public string Code { get; }
    public string Manifest { get; }
    public string[] Categories { get; }
    public string Origin { get; }
    public double Weight { get; }
    public int Status { get; set; }

    public Container(string code, string manifest, string[] categories, string origin, string weight, int status)
    {
        Code = code;
        Manifest = manifest;
        Categories = categories;
        Origin = origin;
        var test = weight.Split(" ");
        Weight = Math.Round(Convert.ToDouble(test[0]) * 0.45359237, 2);
        Status = status;
    }

    public override string ToString()
    {
        string categories = String.Join(",", Categories);
        return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{categories}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}')";
    }
}
