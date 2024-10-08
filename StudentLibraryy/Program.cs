class Book // created a class which has 4 pieces of information in it. In our case they are 3 strings & 1 int
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayInfo() // created method, outputs 4 pieces of information
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
        Book book = new Book(); // book contains the 3 variables, title, author and ISBN. book is the instance

        book.Title = "C# for beginners"; //This is a string and the new title for the book instance
        book.Author = "Bill Gates"; //This is a string for the new author of the book instance
        book.ISBN = "12345677";
        book.NoOfPages = 200;

        Book book2 = new Book(); // Second Book instance, cannot be the same as the first one
        book2.Title = "C# Methods and classes"; // Second title
        book2.Author = "Microsoft"; // second author
        book2.ISBN = "07767114"; // second number
        book2.NoOfPages = 50;

        // Output book information to the console
        book.DisplayInfo(); // calling the method, taking information from book and pritning it out
        book2.DisplayInfo(); // Calling the method, taking the information from book2 and printing it out


    }
}

