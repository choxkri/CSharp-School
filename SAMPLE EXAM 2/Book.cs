public class Book
{
    public string Title { get; }
    public string Author { get; }

    private string _LangSetter;
    public string Language
    {
        get
        {
            return _LangSetter;
        }

        protected set
        {
            _LangSetter = value;
        }
    }

    public Book(string t, string a, string l)
    {
        this.Title = t;
        this.Author = a;
        this.Language = l;
    }

    public Book(string t, string a)
    {
        this.Title = t;
        this.Author = a;
        this.Language = "EN";
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {this.Title}");
        Console.WriteLine($"Author: {this.Author}");
        Console.WriteLine($"Language: {this.Language}");
    }
}