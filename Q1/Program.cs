class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

   //Constructor for book object
   public Book(string bookTitle, string BookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = BookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        //Output the book informastion to the Console
        Console.WriteLine("Book information");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create a new instance of the book class
       Book book = new Book("C# for beginers", "Bill Gates", "12345", 200);
        //another instance
        Book book2 = new Book("Visual studio 2022", "Microsoft", "123", 70);
        // Output book infotrmation to the Console
       book.DisplayInfo();
        book2.DisplayInfo();






    }


}