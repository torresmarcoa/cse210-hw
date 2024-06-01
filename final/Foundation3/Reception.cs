using System; 

public class Reception : Event
{
    private string _email;

    public Reception (string title, string description, string date, string time, Address address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

       public void GetFullDetails()
    {
        Console.WriteLine($"Type {_type}");
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.GetAddressString()}");
        Console.WriteLine($"Email: {_email}");
        Console.WriteLine();
    }
}