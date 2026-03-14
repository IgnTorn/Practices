public class BookService
{
    public static Book[] books = new Book[100];
    public static int bookCount = 0;
    public static int nextId = 11;

    public static void Initialize()
    {
        Book[] initialBooks = new Book[10]
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert Martin", Genre = "Programming", PublishedYear = 2008 },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Genre = "Programming", PublishedYear = 1999 },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Genre = "Programming", PublishedYear = 1994 },
            new Book { Id = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937 },
            new Book { Id = 5, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedYear = 1949 },
            new Book { Id = 6, Title = "Atomic Habits", Author = "James Clear", Genre = "Self Development", PublishedYear = 2018 },
            new Book { Id = 7, Title = "Deep Work", Author = "Cal Newport", Genre = "Productivity", PublishedYear = 2016 },
            new Book { Id = 8, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", PublishedYear = 1997 },
            new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Novel", PublishedYear = 1988 },
            new Book { Id = 10, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedYear = 1960 }
        };

        for (int i = 0; i < initialBooks.Length; i++)
        {
            books[bookCount++] = initialBooks[i];
        }
    }

    public static void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter book author: ");
        string author = Console.ReadLine();
        Console.Write("Enter book genre: ");
        string genre = Console.ReadLine();
        Console.Write("Enter published year: ");
        int publishedYear = int.Parse(Console.ReadLine());
        Book newBook = new Book
        {
            Id = nextId++,
            Title = title,
            Author = author,
            Genre = genre,
            PublishedYear = publishedYear
        };

        books[bookCount++] = newBook;
        Console.WriteLine("Book added successfully");
    }

    public static void GetAllBooks()
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
                books[i].PrintInfo();
        }
    }

    public static void UpdateBook()
    {
        Console.Write("Enter book Id to update: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                Console.Write("Enter new title: ");
                books[i].Title = Console.ReadLine();
                Console.Write("Enter new author: ");
                books[i].Author = Console.ReadLine();
                Console.Write("Enter new genre: ");
                books[i].Genre = Console.ReadLine();
                Console.Write("Enter new published year: ");
                books[i].PublishedYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Book updated successfully");
                return;
            }
        }
        Console.WriteLine("Book not found");
    }

    public static void DeleteBook()
    {
        Console.Write("Enter book Id to delete: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                for (int j = i; j < bookCount - 1; j++)
                    books[j] = books[j + 1];

                books[--bookCount] = null;
                Console.WriteLine("Book deleted successfully");
                return;
            }
        }
        Console.WriteLine("Book not found");
    }
}
