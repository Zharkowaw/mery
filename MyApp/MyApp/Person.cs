class Person
{
    public string name;
    public List<Book> books;

    public Person(string name)
    {
        this.name = name;
        this.books = new List<Book>();
    }

    public void Borrow(Book book)
    {
        if (book.available)
        {
            book.available = false;
            books.Add(book);
            Console.WriteLine("Book borrowed: " + book.title);
        }
        else
        {
            Console.WriteLine("Book not available: " + book.title);
        }
    }

    public void Return(Book book)
    {
        if (books.Contains(book))
        {
            book.available = true;
            books.Remove(book);
            Console.WriteLine("Book returned: " + book.title);
        }
        else
        {
            Console.WriteLine("Person did not borrow this book: " + book.title);
        }
    }

}



