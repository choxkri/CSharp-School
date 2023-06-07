public class Department
{
    public string Name { get; set; }
    private Queue<Request> _requests { get;  set; }

    public Department(string name)
    {
        Name = name;
        _requests = new Queue<Request>();
    }

    public void AddRequest(Request request)
    {
        _requests.Enqueue(request);
    }

    public Request SolveNextRequest()
    {
        return _requests.Dequeue();
    }

    public Request GetNextRequest()
    {
        return _requests.Peek();
    }

    public void PrintAllRequests()
    {
        foreach (Request request in _requests)
        {
            Console.WriteLine(request);
        }
    }
}