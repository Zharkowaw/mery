using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Add books to library
        library.AddBook(new Book(1, "The Great Gatsby"));
        library.AddBook(new Book(2, "To Kill a Mockingbird"));
        library.AddBook(new Book(3, "1984"));
        library.AddBook(new Book(4, "Pride and Prejudice"));

        // Add borrowers to library
        library.AddBorrower(new Person("Alice"));
        library.AddBorrower(new Person("Bob"));

        // Alice borrows a book
        Book book1 = library.books[0];
        Person person1 = library.borrowers[0];
        person1.Borrow(book1);

        // Bob borrows a book
        Book book2 = library.books[1];
        Person person2 = library.borrowers[1];
        person2.Borrow(book2);

        // Alice tries to borrow the same book again
        person1.Borrow(book1);

        // Bob tries to borrow a book that is already borrowed
        person2.Borrow(book1);

        // Alice returns her book
        person1.Return(book1);

        // Bob tries to return a book he didn't borrow
        person2.Return(book1);

        // Print available books and borrowers
        library.PrintBooks();
        library.PrintBorrowers();
    }
}