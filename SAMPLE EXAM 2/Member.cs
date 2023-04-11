public class Member : Person
{
    public override string Name
    {
        get
        {
            return $"{base.Name} (member)";
        }
    }

    private int _BooksBorrowed;
    public int NumberOfBooksBorrowed
    {
        get
        {
            return _BooksBorrowed;
        }

        private set
        {
            _BooksBorrowed = value;
        }
    }

    public Member(string n, int a) : base(n, a)
    {
        this.NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(Book book)
    {
        if (book == null)
        {
            return;
        }

        else if (book is EBook)
        {
            Console.WriteLine($"{this.Name} has borrowed the Ebook {book.Title} by {book.Author}");
        }

        else
        {
            if (NumberOfBooksBorrowed < 3)
            {
                NumberOfBooksBorrowed += 1;
                Console.WriteLine($"{this.Name} has borrowed {book.Title} by {book.Author}");
            }

            else
            {
                Console.WriteLine($"{this.Name} has already borrowed the maximum number of books");
            }

        }
    }

    public override string ToString()
    {
        return $"Name: {this.Name} \nAge: {this.Age} \nBorrowed books: {this.NumberOfBooksBorrowed}";
    }
}