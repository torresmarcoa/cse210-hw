using System; 

public class Reception : Event
{
    // Member variable for the e-mail
    private string _email;

    // constructor that initializes the reception event
    public Reception (string title, string description, string date, string time, Address address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    // Method to get the full details for the reception event
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