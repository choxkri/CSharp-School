class Library
{
    public List<Book> Books;

    public Library(List<Book> books)
    {
        this.Books = books;
    }

    public Library()
    {
        this.Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        this.Books.Add(book);
    }

    public void AddBook(int id, string title)
    {
        Book book = new(id, title);
        this.Books.Add(book);
    }

    public Book FindBook(int id)
    {
        foreach (Book book in this.Books) 
        {
            if (book.ID == id) 
                return book;
        }

        return null;
    }

    public Book FindBook(string id)
    {
        if (id.All(char.IsDigit))
        {
            int term = Convert.ToInt32(id);
            return this.FindBook(term);
        }

        else
        {
            Console.WriteLine($"id = {id}: not a valid book id. input string was not in a correct format.");
            return null;
        }
    }

}