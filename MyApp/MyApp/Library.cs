using System;

class Library
{
    public List<Book> books;
    public List<Person> borrowers;

    public Library()
    {
        this.books = new List<Book>();
        this.borrowers = new List<Person>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddBorrower(Person person)
    {
        borrowers.Add(person);
    }

    public void PrintBooks()
    {
        Console.WriteLine("Books available:");
        foreach (Book book in books)
        {
            if (book.available)
            {
                Console.WriteLine(book.title);
            }
        }
    }

    internal void PrintBorrowers()
    {
        throw new NotImplementedException();
    }
}
