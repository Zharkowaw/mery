class Book
{
    public int id;
    public string title;
    public bool available;

    public Book(int id, string title)
    {
        this.id = id;
        this.title = title;
        this.available = true;
    }
}