using System.Threading.Channels;

public class Program
{
    public static void Main()
    {
        MemberService.Initialize();
        BookService.Initialize();

        while (true)
        {
            Console.WriteLine("1. Show Members\n2. Add Member\n3. Update Member\n4. Delete Member\n5. Show Books\n6. Add Book\n" +
                "7. Update Book\n8. Delete Book\n9. Borrow Book\n10. Return Book\n0. Exit");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            switch (choice)
            {
                case 1:
                    MemberService.GetAllMembers();
                    break;

                case 2:
                    Console.WriteLine("Enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name: ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Enter personal number: ");
                    string personalNumber = Console.ReadLine();

                    MemberService.AddMember(firstName, lastName, age, email, personalNumber);
                    break;

                case 3:
                    MemberService.GetAllMembers();
                    MemberService.UpdateMember();
                    break;

                case 4:
                    MemberService.GetAllMembers();
                    MemberService.DeleteMember();
                    break;

                case 5:
                    BookService.GetAllBooks();
                    break;

                case 6:
                    BookService.AddBook();
                    break;

                case 7:
                    BookService.GetAllBooks();
                    BookService.UpdateBook();
                    break;

                case 8:
                    BookService.GetAllBooks();
                    BookService.DeleteBook();
                    break;

                case 9:
                    MemberService.GetAllMembers();
                    BookService.GetAllBooks();

                    Console.WriteLine("Enter member Id: ");
                    int memberId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter book Id: ");
                    int bookId = int.Parse(Console.ReadLine());

                    LibraryService.BorrowBook(memberId, bookId);
                    break;

                case 10:
                    BookService.GetAllBooks();

                    Console.Write("Enter book Id: ");
                    int returnBookId = int.Parse(Console.ReadLine());

                    LibraryService.ReturnBook(returnBookId);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}