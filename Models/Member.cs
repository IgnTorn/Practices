public class Member
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Age;
    public string Email;
    public string PersonalNumber;
    public DateTime CreatedOn;


    public void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"PersonalNumber: {PersonalNumber}");
        Console.WriteLine("CreatedOn: " + CreatedOn.Date.ToShortDateString());
        Console.WriteLine("----------------------");
    }
}

