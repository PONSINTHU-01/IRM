using System.Reflection;

class Book
{
    private string title;
    private string author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"The Title of the book is:{title} and the author is:{author}");
    }
    public static void Main(string[] args)
    {
        Book b1 = new Book("The Alchemist", "Paulo Coelho");
        b1.DisplayInfo();

        // Using Setter to update title and author
        b1.Title = "The Pilgrimage";
        b1.Author = "Paulo Coelho";

        Console.WriteLine("After updating the title and author");
        b1.DisplayInfo();

        // Using Getter to access values
        Console.WriteLine($"\nTitle using getter: {b1.Title}");
        Console.WriteLine($"Author using getter: {b1.Author}");
         
        Book b2 = new Book("Wings of Fire", "A. P. J. Abdul Kalam");
        b2.DisplayInfo();

        Book b3 = new Book("Pride and Prejudice", "Jane Austen");
        b3.DisplayInfo();
       
    }
}
