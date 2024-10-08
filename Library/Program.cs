class Book
{
    //Properties
    string Title, Author, ISBN;
    int noOfPages;

    //Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        noOfPages = bookNoOfPages;
    }

    static void Main(string[] args)
    {
        //Create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "12345678", 200);
        Book book1 = new Book("C# Methods and classes", "Microsoft", "55667778", 50);
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        //Output book info to the console
        book.displayInfo();
        book1.displayInfo();
        book2.displayInfo();
    }

    void displayInfo()
    {
        //Output the book information to the console
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of pages: {noOfPages}");
        Console.WriteLine();
    }
}
