public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public int CompareTo(Book book)
    {
        if (book == null) return 1;
        if (Year.CompareTo(book.Year) != 0) return Year.CompareTo(book.Year);
        if (Author.CompareTo(book.Author) != 0) return Author.CompareTo(book.Author);
        if (Title.CompareTo(book.Title) != 0) return Title.CompareTo(book.Title);
        return 0;
    }

}