class Book // created a class which has 4 pieces of information in it. In our case they are 3 strings & 1 int
{
    // Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for book object. Constructor always has to be the same as class name
    // add a new instance of the book class
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages) 
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo() // created method, outputs 4 pieces of information.
    {
        // Output the book information to the console
        Console.WriteLine("Book Information");
        Console.WriteLine("----------");
        Console.WriteLine($"Book title: {Title}"); // Do not need the instance name inside brackets as the varibale inside display infor refer straight back to variables.
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book Pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance of the book class. We use a lowercase b for an instance
        Book book = new Book("C# for beginners", "Bill Gates", "12345677", 200);
        // Another Instance
        Book book2 = new Book("Visual Studios 2022", "Microsoft", "123", 70);

        // Output book information to the console
        book.DisplayInfo(); // calling the method, taking information from book and pritning it out
        book2.DisplayInfo(); // Calling the method, taking the information from book2 and printing it out


    }
}

