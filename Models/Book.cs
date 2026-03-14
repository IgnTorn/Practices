public class Book
{
    public int Id;
    public string Title;
    public string Author;
    public string Genre;
    public int PublishedYear;

    public bool IsBorrowed;
    public int? BorrowedByMemberId;

    public void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Published Year: {PublishedYear}");
        Console.WriteLine($"Borrowed: {IsBorrowed}");
        Console.WriteLine("----------------------");
    }
}