public static class MemberService
{
    public static Member[] members = new Member[100];
    public static int memberCount = 0;
    public static int nextId = 1;

    public static void Initialize()
    {
        Member guest = new Member();

        guest.Id = nextId++;
        guest.FirstName = "Jerry";
        guest.LastName = "Gogoladze";
        guest.Age = 30;
        guest.Email = "JerryGogoladze@gmail.com";
        guest.PersonalNumber = "551073121";
        guest.CreatedOn = DateTime.Now;

        members[memberCount++] = guest;
    }

    public static void AddMember(string firstName, string lastName, int age, string email, string personalNumber)
    {
        Member newMember = new Member();
        newMember.Id = nextId++;
        newMember.FirstName = firstName;
        newMember.LastName = lastName;
        newMember.Age = age;
        newMember.Email = email;
        newMember.PersonalNumber = personalNumber;
        newMember.CreatedOn = DateTime.Now;

        members[memberCount++] = newMember;
    }

    public static void GetAllMembers()
    {
        for (int i = 0; i < memberCount; i++)
            members[i].PrintInfo();
    }

    public static void UpdateMember()
    {
        Console.Write("Enter member Id to update: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < memberCount; i++)
        {
            if (members[i].Id == id)
            {
                Console.Write("Enter new first name: ");
                members[i].FirstName = Console.ReadLine();
                Console.Write("Enter new last name: ");
                members[i].LastName = Console.ReadLine();
                Console.Write("Enter new age: ");
                members[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Enter new email: ");
                members[i].Email = Console.ReadLine();
                Console.Write("Enter new personal number: ");
                members[i].PersonalNumber = Console.ReadLine();
                Console.WriteLine("Member updated successfully.");
                return;
            }
        }
        Console.WriteLine("Member not found.");
    }

    public static void DeleteMember()
    {
        Console.Write("Enter member Id to delete: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < memberCount; i++)
        {
            if (members[i].Id == id)
            {
                for (int j = i; j < memberCount - 1; j++)
                    members[j] = members[j + 1];

                members[--memberCount] = null;
                Console.WriteLine("Member deleted successfully.");
                return;
            }
        }
        Console.WriteLine("Member not found.");
    }
}