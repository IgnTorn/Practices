public static class LibraryService
{
    public static void BorrowBook(int memberId, int bookId)
    {
        Member member = null;
        Book book = null;

        for (int i = 0; i < MemberService.memberCount; i++)
        {
            if (MemberService.members[i] != null && MemberService.members[i].Id == memberId)
            {
                member = MemberService.members[i];
                break;
            }
        }

        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }

        for (int i = 0; i < BookService.bookCount; i++)
        {
            if (BookService.books[i] != null && BookService.books[i].Id == bookId)
            {
                book = BookService.books[i];
                break;
            }
        }

        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }

        book.IsBorrowed = true;
        book.BorrowedByMemberId = memberId;

        Console.WriteLine("Book borrowed successfully");
    }

    public static void ReturnBook(int bookId)
    {
        Book book = null;

        for (int i = 0; i < BookService.bookCount; i++)
        {
            if (BookService.books[i] != null && BookService.books[i].Id == bookId)
            {
                book = BookService.books[i];
                break;
            }
        }
        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }
        
        if (!book.IsBorrowed)
        {
            Console.WriteLine("Book is currently not borrowed");
            return;
        }

        book.IsBorrowed = false;
        book.BorrowedByMemberId = null;

        Console.WriteLine("Book returned successfully");
    }
}