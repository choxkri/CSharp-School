class Person
{
    private readonly string _firstName;
    private readonly string _lastName;
    public Person(string fn, string ln)
    {
        this._firstName = fn;
        this._lastName = ln;
    }

    public string FullName
    {
        get { return $"{_firstName} {_lastName}"; }
    }
}